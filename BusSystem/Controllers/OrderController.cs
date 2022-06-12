using BusSystem.Data.Enum;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Razor.Templating.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        private readonly ITicketService _ticketService;
        private readonly IBusScheduleService _busScheduleService;
        public OrderController(IOrderService orderService, ITicketService ticketService, IBusScheduleService busScheduleService)
        {
            _orderService = orderService;
            _ticketService = ticketService;
            _busScheduleService = busScheduleService;
        }

        [Route("user/order/{id}")]
        public async Task<IActionResult> GetOrderDetail(int id)
        {
            var tick = await _orderService.OrderDetail(id);
            var htmlString = await RazorTemplateEngine.RenderAsync("/Views/Partner/Account/ModalInfo.cshtml", tick);

            return StatusCode(200, new {status = true, data = htmlString });
        }

        [Route("user/order/cancel/{id}")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            var now = DateTime.Now;
            var tick = await _orderService.OrderDetail(id);

            if (tick == null)
            {
                return StatusCode(422, new { status = false, message = "Ticket not found!" });
            }
            if (tick.StartTime <= now)
            {
                return StatusCode(422, new { status = false, message = "The trip time has expired, the order cannot be canceled!" });
            }
            if (tick.OrderStatus == (int)OrderStatus.INACTIVE)
            {
                return StatusCode(422, new { status = false, message = "Order is cancel" });

            }
            var disc = 0;

            var days = (tick.StartTime - now).TotalDays;

            var message = "Refund for OrderId: " + id;

            if (days > 2 && days <= 1)
            {
                disc = 15;
                message += " lost 15% / " + tick.Amount + "$ less 2 day";
            }
            else if (days < 1)
            {
                disc = 30;
                message += " lost 30% / " + tick.Amount + "$ less 1 dáy";
            }
            var cal = (decimal)tick.Amount * (decimal)(disc * 0.01);

            var amount = ((decimal)tick.Amount - cal);

            var cancel = await _orderService.CancelOder(id, amount, message);
            if (cancel == true)
            {
                return StatusCode(200, new { status = true, message = "Cancel Success!;" });
            }
            return Json(1);
        }
    }
}
