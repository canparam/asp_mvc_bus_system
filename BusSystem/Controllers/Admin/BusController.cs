using BusSystem.Entity;
using BusSystem.Helper;
using BusSystem.Model.Bus;
using BusSystem.Model.Response;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    public class BusController : BaseController
    {
        private readonly IBusService _busService;
        const int PAGE_SIZE = 10;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }
        [Route("admin/bus", Name = "admin.bus")]
        public IActionResult Index(int page = 1)
        {
            
            var result = _busService.List(page, PAGE_SIZE, null);
            return View("~/Views/Admin/Bus/Index.cshtml", result);
        }

        [Route("admin/bus/create", Name = "admin.bus.create")]
        [HttpPost]
        public IActionResult CreateBus(CreateBusModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var bus = new Bus()
            {
                Name = model.Name,
                Quantity = model.Quantity,
                Status = model.Status,
                CreatedDate = DateTime.Now
            };
            var result = _busService.CreateBus(bus);
            if (result != null)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }


        [Route("admin/bus/{id}", Name = "admin.bus.detail")]
        [HttpGet]
        public IActionResult GetDetail(int id)
        {
            var bus = _busService.FindById(id);
            if (bus != null)
            {
                return StatusCode(200, new {status = true, data = bus });
            }
            return StatusCode(400, new {Message = "Bus not found" });
        }


        [Route("admin/bus/update/{id}", Name = "admin.bus.update")]
        [HttpPost]
        public IActionResult Update(CreateBusModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var bus = _busService.FindById(id);
            
            if (bus == null)
            {
                return StatusCode(400, new { Message = "Bus not found" });
            }
            bus.Name = model.Name;
            bus.Quantity = model.Quantity;
            bus.Status = model.Status;
            bus.ModifiedDate = DateTime.Now;
            bus.ModifiedBy = HttpContext.User.Identity.Name;
            var result = _busService.UpdateBus(bus);
            if (result == true)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }
    }
}
