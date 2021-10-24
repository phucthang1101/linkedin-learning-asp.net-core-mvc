using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreOntario.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreOntario.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index(int page = 0)
        {
            /*
            // DUMMY_VARIABLE
            var post = new[]
            {
                new Post
                {
                    Title = "My first blog post",
                    Author = "Thang Tran",
                    Posted = DateTime.Now,
                    Body = "This is the body of my blog. Content goes here! Below are a few of a latest posts from some of our explorers."
                },

                new Post
                {
                    Title = "My second blog post",
                    Author = "Thang Tran",
                    Posted = DateTime.Now,
                    Body = "This is the body of my blog. Content goes here! Below are a few of a latest posts from some of our explorers."
                }

            }; 
            */
            /* Normal rendering post 
            var post = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();
            */

            // paging
            var pageSize = 2;
            var totalPosts = _db.Posts.Count();
            var totalPages = totalPosts / pageSize + totalPosts % pageSize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage < totalPages;


            var posts =
                    _db.Posts
                    .OrderByDescending(x => x.Posted)
                    .Skip(pageSize * page)
                    .Take(pageSize)
                    .ToArray();

            // detect ajax call of jquery code in site.js, cuz whenever there is a ajax call there will be a header name XMLHttpRequest
            // then we will only return the PartialView, so that our page wont reload 
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(posts);
            return View(posts);
        }

        //[Route("blog/{year:int}/{month:int}/{key}")]
        //Set range for value
        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")] 
        public IActionResult Post(int year, int month, string key)
        {
            //return new ContentResult{
            //    Content = string.Format("Year: {0};     Month: {1};     Key:{2}",
            //                            year, month, key)
            //};


            //// Pass dynamic data to View using ViewBag
            //ViewBag.Title = "My blog post";
            //ViewBag.Author = "Thang Tran";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Body = "This is the body of my blog. Content goes here!";


            //Render data with defined class 
            //var post = new Post
            //{
            //    Title = "My blog post",
            //    Posted = DateTime.Now,
            //    Author = "Jess Chadwick",
            //    Body = "This is a great blog post, don't you think?",
            //};

            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            return View(post);
        }

        [Authorize]
        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost, Route("Create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
                return View();
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }
    }
}