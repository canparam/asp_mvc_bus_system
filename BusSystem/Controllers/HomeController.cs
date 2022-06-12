using BusSystem.Entity.IdentityAccess;
using BusSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        public HomeController( SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        [Route("", Name = "home.index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/logout", Name = "user.logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }

    }
}
