using BusSystem.Model.Order;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Razor.Templating.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    public class OrderController : BaseController
    {
        const int PAGE_SIZE = 20;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [Route("admin/order", Name = "admin.order.list")]
        public IActionResult Index(string username, int page = 1)
        {
            var search = new OrderSearchModel()
            {
                UserName = username
            };
            ViewBag.search = search;
            var result = _orderService.ListOrder(page,PAGE_SIZE,search);
            return View("~/Views/Admin/Order/Index.cshtml", result);
        }
        [Route("admin/order/{id}")]
        public async Task<IActionResult> GetOrderDetail(int id)
        {
            var tick = await _orderService.OrderDetail(id);
            var htmlString = await RazorTemplateEngine.RenderAsync("/Views/Admin/Order/ModalInfo.cshtml", tick);

            return StatusCode(200, new { status = true, data = htmlString });
        }
    }
}
