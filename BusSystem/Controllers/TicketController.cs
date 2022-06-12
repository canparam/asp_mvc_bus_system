using BusSystem.Entity;
using BusSystem.Model.BusSchedule;
using BusSystem.Model.Order;
using BusSystem.Model.Response;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers
{
    public class TicketController : BaseController
    {
        private readonly IBusService _busService;
        private readonly IScheduleService _scheduleService;
        private readonly IBusScheduleService _BusScheduleService;
        private readonly ICustomerService _customerService;
        private readonly IWalletService _walletService;
        private readonly IOrderService _orderService;
        private readonly ITicketService _ticketService;
        const int PAGE_SIZE = 10;
        public TicketController(IOrderService orderService, IBusService busService, IScheduleService scheduleService,
            IBusScheduleService busScheduleService, ICustomerService customerService, IWalletService walletService, ITicketService ticketService)
        {
            _busService = busService;
            _scheduleService = scheduleService;
            _BusScheduleService = busScheduleService;
            _customerService = customerService;
            _walletService = walletService;
            _ticketService = ticketService;
            _orderService = orderService;
        }
        [Route("ticket", Name = "partner.ticket.index")]
        public IActionResult Index(string from, string to, string time, Dictionary<int, string> fleetType, int page = 1)
        {
            var noPaging = true;
            var status = 0;
            var bus = _busService.List(0, 0, status, noPaging);
            var local = _scheduleService.List(0, 0, status, noPaging);

            List<int> busFilter = new List<int>();

            foreach (KeyValuePair<int, string> entry in fleetType)
            {
                busFilter.Add(entry.Key);
            }

            SelectList listLocalFrom = new SelectList(local, "From", "From");
            SelectList listLocalTo = new SelectList(local, "To", "To");

            ViewBag.bus = bus;
            ViewBag.from = listLocalFrom;
            ViewBag.to = listLocalTo;
            ViewBag.time = time;
            ViewBag.busFilter = busFilter.ToArray();

            var search = new BusScheduleSearchModel()
            {
                From = from,
                To = to,
                Bus = busFilter.ToArray()
            };
            if (!string.IsNullOrEmpty(time))
            {
                string[] words = time.Split(" to ");

                DateTime StartTime = DateTime.ParseExact(words[0] + " 00:00:00", "dd-MM-yyyy HH:mm:ss", null);

                DateTime EndTime = DateTime.ParseExact(words[1] + " 23:59:59", "dd-MM-yyyy HH:mm:ss", null);

                search.StartTime = StartTime;
                search.EndTime = EndTime;
            }



            var listSche = _BusScheduleService.ListScheduleActive(page, PAGE_SIZE, search);
            return View("~/Views/Partner/Ticket/Index.cshtml", listSche);
        }

        [Route("ticket/order/{id}", Name = "partner.ticket.order")]
        public IActionResult Order(int id)
        {
            var ticket = _BusScheduleService.GetFirstViewModelById(id);
            var page = 1;
            var customer = _customerService.List(page, PAGE_SIZE, true);

            ViewBag.customers = customer;
            return View("~/Views/Partner/Ticket/Order.cshtml", ticket);
        }
        [Route("ticket/custom-detail/{phone}", Name = "partner.ticket.detail")]
        public IActionResult GetCustomDetail(string phone)
        {
            var customer = _customerService.GetFirstByPhone(phone);

            return StatusCode(200, new { status = true, data = customer });
        }

        [Route("ticket/order/create", Name = "partner.ticket.order.post")]
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(401, ModelState.Errors());
            }

            var busSche = _BusScheduleService.GetFirstViewModelById(model.BusCheduleId);
            if (busSche == null)
            {
                return StatusCode(401, new { message = "Not found" });
            }

            var total = _orderService.GetTotalTicketByBusScheId((int)busSche.Id);

            if (total >= busSche.NumberPassengers)
            {
                return StatusCode(200, new { status = false, message = "Tickets are sold out" });
            }


            var today = DateTime.Today;

            var discount = 0;
            // Calculate the age.
            var age = today.Year - model.Birthday.Year;
            if (age <= 5)
            {
                discount = 100;
            }
            else if (age > 5 && age <= 12)
            {
                discount = 50;
            }
            else if (age > 50)
            {
                discount = 30;
            }
            var cal = busSche.PriceTicket.Value * (decimal)(discount * 0.01);

            var amount = (busSche.PriceTicket - cal);

            var accAmount = await _walletService.UserAmount();

            if (accAmount < amount)
            {
                return StatusCode(200, new { status = false, message = "Your account does not have enough credit" });
            }

            model.Discount = discount;
            model.Amount = (decimal)amount;

            Order order = await _orderService.CreateOrderAsync(busSche, model);

            if (order != null)
            {
                var tiket = _ticketService.GetTicketDetailByOrderId(order.Id);
                return StatusCode(200, new { status = true, data = tiket });
            }
            return Json(1);
        }

    }
}
