using BusSystem.Attributes;
using BusSystem.Data.Interfaces;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    [Authorize]
    public class DashboardController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWalletService _walletService;
        private readonly ITransactionHisService _transactionHisService;
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IUserService _userService;
        public DashboardController(UserManager<User> userManager,
            SignInManager<User> signInManager, IWalletService walletService, ILogger<DashboardController> logger, ITransactionHisService transactionHisService, IOrderService orderService, ICustomerService customerService, IUserService userService)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _walletService = walletService;
            _transactionHisService = transactionHisService;
            _orderService = orderService;
            _customerService = customerService;
            _userService = userService;
        }
        [Route("admin/", Name = "admin.index")]
        [Route("admin/dashboard", Name = "admin.dashboard")]
        public async Task<IActionResult> IndexAsync()
        {
            User user = await _userManager.GetUserAsync(User);

            var totalTras = _transactionHisService.GetSumTotal();
            var wallet = _walletService.GetUserWallet(user);
            var chart = _orderService.GetDataChart();

            ViewBag.totalTras = totalTras;
            ViewBag.totalCustomer = _customerService.GetTotalCustomer();
            ViewBag.totalOrder = _orderService.GetTotalOrder();
            ViewBag.totalPartner = _userService.GetTotalPartner();
            ViewBag.top10 = _userService.TopPartner(5);
            ViewBag.chart = chart;
            return View("~/Views/Admin/Dashboard/Index.cshtml");
        }
    }
}
