using BusSystem.Data.Enum;
using BusSystem.Entity;
using BusSystem.Helper;
using BusSystem.Model.BusSchedule;
using BusSystem.Model.Response;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor.Templating.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    public class BusScheduleController : BaseController
    {
        private readonly IScheduleService _scheduleService;
        private readonly IBusService _busService;
        private readonly IBusScheduleService _busScheduleService;

        const int PAGE_SIZE = 20;
        public BusScheduleController(IScheduleService scheduleService, IBusService busService, IBusScheduleService busScheduleService)
        {
            _scheduleService = scheduleService;
            _busService = busService;
            _busScheduleService = busScheduleService;
        }
        [Route("admin/busschedule", Name = "admin.busschedule.index")]
        public IActionResult Index(string BusName, int? status, int page = 1)
        {
            var listStatus = new List<Model.Order.OrderStatusModel>()
            {
                new Model.Order.OrderStatusModel(){ Name = "Active", Value = (int)OrderStatus.ACTIVE},
                new Model.Order.OrderStatusModel(){ Name = "InActive", Value = (int)OrderStatus.INACTIVE},
            };
            SelectList statusList = new SelectList(listStatus, "Value", "Name");

            var result = _busScheduleService.List(page, PAGE_SIZE, BusName, status, false);

            ViewBag.listStatus = statusList;
            ViewBag.BusName = BusName;

            return View("~/Views/Admin/BusSchedule/Index.cshtml", result);
        }

        [Route("admin/busschedule/create", Name = "admin.busschedule.create")]
        public IActionResult Create()
        {
            var noPaging = true;
            var page = 1;
            var status = 0;
            var listSch = _scheduleService.List(page, PAGE_SIZE, status, noPaging);
            var listBus = _busService.List(page, PAGE_SIZE, status, noPaging);

            ViewBag.lisSchedule = listSch;
            ViewBag.listBus = listBus;
            return View("~/Views/Admin/BusSchedule/Create.cshtml");
        }

        [Route("admin/busschedule/create", Name = "admin.busschedule.create.post")]
        [HttpPost]
        public IActionResult CreateBusSche(CreateBusScheduleModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var bus = _busService.FindById((int)model.BusId);
            if (bus == null)
            {
                return StatusCode(400, new { message = "Bus not found" });
            }
            var timeSch = _scheduleService.GetTimeScheduleById((int)model.ScheduleTimeId);
            if (timeSch == null)
            {
                return StatusCode(400, new { message = "ScheduleTime not found" });
            }
            var busSCh = new BusSchedule()
            {
                BusId = (int)model.BusId,
                PriceTicket = (decimal)model.Price,
                TimeScheduleId = (int)model.ScheduleTimeId,
                CreatedDate = DateTime.Now,
                Status = (int)BusScheduleStatus.ACTIVE
            };
            var result = _busScheduleService.CeateBusSchedule(busSCh);
            if (result != null)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }

        [Route("admin/busschedule/list-time", Name = "admin.busschedule.list-time")]
        [HttpPost]
        public IActionResult ListTimeSchedule(int id)
        {
            var page = 1;
            var result = _scheduleService.ListTime(page, PAGE_SIZE, id);

            return StatusCode(200, new { status = true, data = result });
        }

        [Route("admin/busschedule/delete", Name = "admin.busschedule.delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _busScheduleService.GetById(id);
            if (result == null)
            {
                TempData["message"] = "BusChedule not found";
            }
            else
            {
                result.IsDel = (int)IsDel.DEL;
                bool rs = _busScheduleService.UpdateBusSche(result);
                if (rs == true)
                {
                    TempData["message"] = "Delete Success!";
                }
                else
                {
                    TempData["message"] = "Delete Error!";
                }
            }


            return RedirectToAction("Index");
        }


        [Route("admin/busschedule/detail/{id}", Name = "admin.busschedule.detail")]
        [HttpGet]
        public async Task<IActionResult> DetailAsync(int id)
        {
            var result = _busScheduleService.GetFirstViewModelById(id);
            if (result == null)
            {
                return StatusCode(400, new { message = "Schedule not found" });
            }
            var status = 0;

            var noPaging = true;
            var page = 1;
            var listSch = _scheduleService.List(page, PAGE_SIZE, status, noPaging);
            var listBus = _busService.List(page, PAGE_SIZE, status, noPaging);
            var listTimeBySch = _scheduleService.ListTime(1,1,result.ScheduleId,true);

            var viewDataOrViewBag = new Dictionary<string, object>();
            viewDataOrViewBag["listBus"] = listBus;
            viewDataOrViewBag["listSch"] = listSch;
            viewDataOrViewBag["listTimeBySch"] = listTimeBySch;

            var htmlString = await RazorTemplateEngine.RenderAsync("/Views/Admin/BusSchedule/ModalEdit.cshtml", result, viewDataOrViewBag);

            return StatusCode(200, new { status = true, data = htmlString });
        }

        [Route("admin/busschedule/update/{id}", Name = "admin.busschedule.update")]
        [HttpPost]
        public IActionResult Update(CreateBusScheduleModel model, int id)
        {

            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var result = _busScheduleService.GetById(id);
            if(result == null)
            {
                return StatusCode(400, new { message = "ScheduleTime not found" });

            }
            result.BusId = (int)model.BusId;
            result.PriceTicket = (decimal)model.Price;
            result.TimeScheduleId = (int)model.ScheduleTimeId;
            result.ModifiedDate = DateTime.UtcNow;
            result.Status = model.Status;
            var check = _busScheduleService.UpdateBusSche(result);
            if (check == true)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }
    }
}
