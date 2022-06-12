using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public AuthController(UserManager<User> userManager,
            SignInManager<User> signInManager)
        {

            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [Route("admin/auth/login", Name = "admin.login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToRoute("admin.dashboard");
            }
            return View("~/Views/Admin/Auth/Login.cshtml");
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("admin/auth/login", Name = "admin.login.post")]
        public async Task<IActionResult> Login(LoginUserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, true);
                if (result.Succeeded)
                {
                    return RedirectToRoute("admin.index");
                }

                else
                {
                    ModelState.AddModelError("message", "Login fail");
                    return View("~/Views/Admin/auth/Login.cshtml", model);
                }
            }
            return View("~/Views/Admin/auth/Login.cshtml", model);
        }
        [Authorize]
        [Route("admin/auth/logout", Name = "admin.logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToRoute("admin.login");
        }

    }
}
