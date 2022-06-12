using BusSystem.Entity.IdentityAccess;
using BusSystem.Model.Role;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    [Authorize]
    public class RoleController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IRoleService _roleService;   
        public RoleController(UserManager<User> userManager, SignInManager<User> signInManager, IRoleService roleService)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _roleService = roleService;
        }

        [Route("admin/role", Name = "admin.role.index")]
        public IActionResult Index(int page = 1)
        {
           
            ViewBag.Roles = _roleService.List();
            return View("~/Views/Admin/Role/Index.cshtml");
        }
        [Route("admin/role", Name = "admin.role.post_create")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleModel model)
        {
            if (ModelState.IsValid)
            {
                var role = new Role() { Name = model.Name, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, };
                await _roleService.CreateRole(role);
                ViewBag.message = "Create Success";
            }
            ViewBag.Roles = _roleService.List();
            return View("~/Views/Admin/Role/Index.cshtml", model);


        }
        [Route("admin/role/del", Name = "admin.role.delete")]
        [HttpPost]
        public IActionResult Remove(string Id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.message = "Id is required";
                return View("~/Views/Admin/Role/Index.cshtml");
            }
            var del = _roleService.RemoveRole(Id);
            if (!del)
            {
                ViewBag.message = "Error";
                return View("~/Views/Admin/Role/Index.cshtml");
            }
            ViewBag.message = "Delete Success!";
            ViewBag.Roles = _roleService.List();
            return View("~/Views/Admin/Role/Index.cshtml");
        }
    }
}
