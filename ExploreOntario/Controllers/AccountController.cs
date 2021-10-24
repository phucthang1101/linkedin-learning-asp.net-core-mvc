using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreOntario.Models;
using ExploreOntario.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExploreOntario.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signinManager;
        private readonly UserManager<IdentityUser> _userManager;
        

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signinManager)
        {
            _signinManager = signinManager;
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        //Task<TResult> represent an asynchronous operation that can return value
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            var newUser = new IdentityUser
            {
                Email = registration.EmailAddress,
                UserName = registration.EmailAddress,

            };


            var result = await _userManager.CreateAsync(newUser, registration.Password);

            if(!result.Succeeded)
            {
                foreach(var error in result.Errors.Select(x=>x.Description))
                {
                    ModelState.AddModelError("", error);
                }
                return View();
            }

            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl = "")
        {
            if (!ModelState.IsValid)
                return View();
            
            var result = await _signinManager.PasswordSignInAsync(
                login.EmailAddress, login.Password,
                login.RememberMe, false
                );

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login error!");
                return View();
            }

            //returnUrl: contain the URL that user is requesting to access, before they have to sign in
            // hence, check if it is NULL, 
            // true: redirect them to homepage
            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            //false (means there is a returnURL) then direct them to that URL
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signinManager.SignOutAsync();

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            return Redirect(returnUrl);
        }


    }
}