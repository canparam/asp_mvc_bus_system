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
    public class AccountController : BaseController
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderService;
        private readonly ITransactionHisService _transactionHisService;
        const int PAGE_SIZE = 10;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IOrderService orderService, ITransactionHisService transactionHisService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _orderService = orderService;
            _transactionHisService = transactionHisService;
        }
        [Route("/user", Name = "partner.dashboard.user")]
        public async Task<IActionResult> Index(int page = 1 )
        {
            var result =  await _transactionHisService.ListTranHistByUser(page, PAGE_SIZE);
            return View("~/Views/Partner/Account/Dashboard.cshtml", result);
        }
        [Route("/user/profile", Name = "partner.user_profile")]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View("~/Views/Partner/Account/Profile.cshtml", user);
        }
        [Route("/user/history", Name = "partner.user_history")]
        public async Task<IActionResult> BookingHistory(int page = 1)
        {
            var result = await _orderService.ListOrderByUser(page,PAGE_SIZE);
            return View("~/Views/Partner/Account/History.cshtml", result);
        }
        [Route("/user/change-password", Name = "partner.user_change_password")]
        public IActionResult UpdatePass()
        {
            return View("~/Views/Partner/Account/ChangePassword.cshtml");
        }
        [Route("/user/change-password", Name = "partner.user_change_password.post")]
        [HttpPost]
        public async Task<IActionResult> UpdatePass(UpdatePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.GetUserAsync(HttpContext.User);
                bool checkp =  await _userManager.CheckPasswordAsync(user,model.OldPassword);
                if (checkp == false)
                {
                    ModelState.AddModelError("message", "Old Password not match");
                    return View("~/Views/Partner/Account/ChangePassword.cshtml", model);
                }
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                await _userManager.UpdateAsync(user);
                TempData["message"] = "Update success!";
                return RedirectToAction("UpdatePass");

            }
            return View("~/Views/Partner/Account/ChangePassword.cshtml",model);

        }

        [Route("/user/logout", Name ="partner.logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();

            return RedirectToRoute("partner.login");
        }
    }
}
