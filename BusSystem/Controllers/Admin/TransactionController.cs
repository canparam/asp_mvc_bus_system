using BusSystem.Data.Enum;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Helper;
using BusSystem.Model.Response;
using BusSystem.Model.Transacion;
using BusSystem.Services.Extensions;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{

    public class TransactionController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;
        private readonly IWalletService _walletService;
        private readonly ITransactionHisService _transactionHisService;
        const int PAGE_SIZE = 10;
        public TransactionController(UserManager<User> userManager, SignInManager<User> signInManager, IUserService userService,
            IWalletService walletService, ITransactionHisService transactionHisService)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _walletService = walletService;
            _transactionHisService = transactionHisService;
        }
        [Route("admin/transaction/transfer", Name = "admin.transaction.transfer")]
        public IActionResult Create()
        {
            return View("~/Views/Admin/Transaction/Transer.cshtml");
        }
        [Route("admin/transaction", Name = "admin.transaction")]
        public IActionResult History(int? type, int? status, string username, int page = 1)
        {

            var listStatus = new List<Model.Transacion.TransactionStatus>()
            {
                new Model.Transacion.TransactionStatus(){ Name = "Plus", Value = (int)Data.Enum.TransactionStatus.PLUS},
                new Model.Transacion.TransactionStatus(){ Name = "Sub", Value = (int)Data.Enum.TransactionStatus.SUB},
            };

            var listType = new List<Model.Transacion.TransactionType>()
            {
                new Model.Transacion.TransactionType(){ Name = "From Admin", Value = (int)Data.Enum.TransactionType.ADMIN_SEND},
                new Model.Transacion.TransactionType(){ Name = "Buy", Value = (int)Data.Enum.TransactionType.BUY},
                new Model.Transacion.TransactionType(){ Name = "Refund", Value = (int)Data.Enum.TransactionType.REFUND},
            };

            SelectList statusList = new SelectList(listStatus, "Value", "Name");
            SelectList types = new SelectList(listType, "Value", "Name");

            var result = _transactionHisService.ListTransHis(page, PAGE_SIZE, type, status, username);

            ViewBag.statusOption = statusList;
            ViewBag.typeOption = types;
            ViewBag.username = username;
            return View("~/Views/Admin/Transaction/History.cshtml", result);
        }
        [Route("admin/transaction/partner-active", Name = "admin.transaction.list_user.active")]
        [HttpPost]
        public IActionResult ListPartnerActive(string username)
        {
            int status = 0;
            string email = "";
            int page = 1;
            var result = _userService.ListPartner(page, PAGE_SIZE, username, email, status);

            return StatusCode(200, result);
        }
        [Route("admin/transaction/transfer", Name = "admin.transaction.transfer.post")]
        [HttpPost]
        public async Task<IActionResult> SendCredit(TranserCreditModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var partner = _userService.GetById(model.UserId);
            if (partner == null)
            {
                return StatusCode(400, new { message = "User not found" });
            }
            model.Status = (int)Data.Enum.TransactionStatus.PLUS;
            model.Type = (int)Data.Enum.TransactionType.ADMIN_SEND;
            var trans = await _walletService.TransactionCredit(partner, model);
            if (trans == true)
            {
                return StatusCode(200, new { status = true });

            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }

        [Route("admin/transaction/rollback", Name = "admin.transaction.rollback.post")]
        [HttpPost]
        public async Task<IActionResult> RollBack( string message, int id = -1)
        {
            var tras = await _transactionHisService.GetByIdAsync(id);

            if (tras == null)
            {
                return StatusCode(400, new { message = "Transaction not found" });
            }
            if (tras.Type != (int)Data.Enum.TransactionType.ADMIN_SEND)
            {
                return StatusCode(400, new { message = "Transaction cant rollback" });
            }
            var user = await _userService.GetByIdAsync(tras.UserId);
            var create = new TranserCreditModel()
            {
                Credit = tras.Credit,
                Message = message,
                Status = (int)Data.Enum.TransactionStatus.SUB,
                Type = (int)Data.Enum.TransactionType.ADMIN_ROLLBACK,
            };
            var wall = await _walletService.TransactionCredit(user, create);
            if (wall == true)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }
    }
}
