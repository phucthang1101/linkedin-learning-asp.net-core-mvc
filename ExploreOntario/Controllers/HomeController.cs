using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreOntario.Models;

namespace ExploreOntario.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Pass dynamic data to View using ViewBag
            ViewBag.Title = "My blog post";
            ViewBag.Author = "Thang Tran";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Body = "This is the body of my blog. Content goes here!";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
