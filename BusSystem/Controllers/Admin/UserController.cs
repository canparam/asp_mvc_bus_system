using BusSystem.Data.Enum;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Response;
using BusSystem.Model.User;
using BusSystem.Services.Interfaces;
using BusSytem.Services.Implements;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    
    public class UserController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        [Obsolete]
        private readonly IUserService _userService;
        private readonly IWalletService _walletService;
        private readonly ICustomerService _customerService;
        const int PAGE_SIZE = 20;
        [Obsolete]
        public UserController(IWalletService walletService, IUserService userService, UserManager<User> userManager,
            SignInManager<User> signInManager, ICustomerService customerService)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _walletService = walletService;
            _customerService = customerService;
        }
        [Route("admin/partner", Name = "admin.partner.list")]
        public IActionResult Index(string username, string email,int? status, int page = 1)
        {
            
            var result = _userService.ListPartner(page, PAGE_SIZE, username, email, status);

            ViewBag.username = username;
            ViewBag.email = email;
            return View("~/Views/Admin/User/Index.cshtml", result);
        }

        


        [Route("admin/partner/add", Name = "admin.partner.add")]
        [HttpGet]
        public IActionResult AddPartner()
        {
            return View("~/Views/Admin/User/AddPartner.cshtml");
        }
        [Route("admin/partner/add", Name = "admin.partner.add.post")]
        [HttpPost]
        public async Task<IActionResult> AddPartner(CreatePartnerModel model)
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
                        TempData["message"] = "Create partner success!";
                        return RedirectToAction("Index");
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
            return View("~/Views/Admin/User/AddPartner.cshtml", model);
        }

        [Route("admin/partner/del/{id}", Name = "admin.partner.delete")]
        [HttpDelete]
        public IActionResult Remove(string Id)
        {
            _userService.RemovePartner(Id);
            return StatusCode(200, new { status = true });
        }

        [Route("admin/partner/detail", Name = "admin.partner.detail.json")]
        [HttpPost]
        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return Json(
                       new JsonErrorModel
                       {
                           StatusCode = -1,
                           ErrorMessage = "User not found"
                       }
                       );
            }
            return Json(
                new JsonSuccessModel
                {
                    StatusCode = 200,
                    Data = user
                }
                );
        }

        [Route("admin/partner/update/{id}", Name = "admin.partner.update.json")]
        [HttpPost]
        public async Task<IActionResult> UpdatePartner(PartnerUpdateModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                var modelErros = ModelState.Errors();

                return StatusCode(401, modelErros);
            }
            User result = await _userManager.FindByIdAsync(id);
            if (result == null)
            {
                return StatusCode(401, new { message = "User not found" });
            }
            result.FullName = model.FullName;
            result.Address = model.Address;
            result.PhoneNumber = model.PhoneNumber;
            result.Status = model.Status;
            if (!string.IsNullOrEmpty(model.Password))
            {
                result.PasswordHash = _userManager.PasswordHasher.HashPassword(result, model.Password);
            }
            await _userManager.UpdateAsync(result);

            return StatusCode(200, new { status = true });
        }


        [Route("admin/customer", Name = "admin.customer")]
        public IActionResult ListCustomer(int page = 1)
        {
            var result = _customerService.ListTest(page,PAGE_SIZE,false);
            return View("~/Views/Admin/Customer/Index.cshtml", result);
        }
    }
}
