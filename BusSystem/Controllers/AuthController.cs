using BusSystem.Data.Enum;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.User;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWalletService _walletService;
        public AuthController(UserManager<User> userManager,
            SignInManager<User> signInManager, IWalletService walletService)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _walletService = walletService;
        }


        [Route("login", Name = "partner.login")]
        public IActionResult Login()
        {
            return View("~/Views/Partner/Auth/Login.cshtml");
        }

        [Route("login", Name = "partner.login.post")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginUserModel model)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await _userManager.FindByNameAsync(model.Username);

                if (userCheck.Status == (int)UserStatus.LOCK)
                {
                    ModelState.AddModelError("message", "Account is Lock.");
                    return View("~/Views/Partner/Auth/Login.cshtml", model);
                }

                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, true);
                if (result.Succeeded)
                {
                    return RedirectToRoute("partner.ticket.index");
                }

                else
                {
                    ModelState.AddModelError("message", "Login fail");
                    return View("~/Views/Partner/Auth/Login.cshtml", model);
                }
            }
            return View("~/Views/Partner/Auth/Login.cshtml", model);
        }

        [Route("signup", Name = "partner.signup")]
        public IActionResult SignUp()
        {
            return View("~/Views/Partner/Auth/SignUp.cshtml");
        }

        [Route("signup", Name = "partner.signup.post")]
        [HttpPost]
        public async Task<IActionResult> SignUp(CreatePartnerModel model)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await _userManager.FindByEmailAsync(model.Email);
                if (userCheck != null)
                {
                    ModelState.AddModelError("message", "Email already exists.");
                }
                else
                {
                    var user = new User()
                    {
                        Email = model.Email,
                        UserName = model.Username,
                        Address = model.Address,
                        PhoneNumber = model.PhoneNumber,
                        FullName = model.FullName,
                        Type = (int)UserType.PARTNER
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await _walletService.CreateUserWalletAsync(user);
                        return RedirectToRoute("partner.login.post");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("message", error.Description);
                        }
                    }

                }
            }
            return View("~/Views/Partner/Auth/SignUp.cshtml", model);
        }
    }
}
