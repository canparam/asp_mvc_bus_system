using BusSystem.Entity;
using BusSystem.Helper;
using BusSystem.Model.Response;
using BusSystem.Model.Schedule;
using BusSystem.Model.TimeSchedule;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    public class ScheduleController : BaseController
    {
        private readonly IScheduleService _scheduleService;
        const int PAGE_SIZE = 10;
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [Route("admin/schedule",Name = "admin.schedule")]
        public IActionResult Index(int page = 1)
        {
            var result = _scheduleService.List(page,PAGE_SIZE,null);
            return View("~/Views/Admin/Schedule/Index.cshtml", result);
        }
        [Route("admin/schedule", Name = "admin.schedule.post")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateScheduleModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var sc = new Schedule()
            {
                To = model.To,
                From = model.From,
                CreatedDate = DateTime.Now,
                Status = model.Status
            };
            var result = await _scheduleService.CreateSchedule(sc);
            if (result != null)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }

        [Route("admin/schedule/{id}", Name = "admin.schedule.detail")]
        [HttpGet]
        public IActionResult GetDetail(int id)
        {
            var result = _scheduleService.GetById(id);

            if (result == null)
            {
                return StatusCode(400,new { message = "Schedule not found" });
            }

            return StatusCode(200, new {status = true, data = result });
        }

        [Route("admin/schedule/{id}", Name = "admin.schedule.put")]
        [HttpPut]
        public IActionResult Update(CreateScheduleModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var sche = _scheduleService.GetById(id);
            if (sche == null)
            {
                return StatusCode(400, new { message = "Schedule not found" });
            }
            sche.ModifiedBy = HttpContext.User.Identity.Name;
            sche.To = model.To;
            sche.From = model.From;
            sche.ModifiedDate = DateTime.Now;
            sche.Status = model.Status;
            var result = _scheduleService.UpdateSch(sche);
            if (result == true)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }

        [Route("admin/schedule/time/{id}", Name = "admin.schedule.time")]
        public IActionResult ListTimeBySchedule(int id, int page = 1)
        {
            var sch = _scheduleService.GetById(id);
            if (sch == null)
            {
                TempData["message"] = "Schedules not found";
                return RedirectToAction("Index");
            }
            var result = _scheduleService.ListTime(page,PAGE_SIZE,sch.Id);
            ViewBag.schedule = sch;
            return View("~/Views/Admin/Schedule/ListTimeBySchedule.cshtml", result);
        }

        [Route("admin/schedule/time/create", Name = "admin.schedule.time.create")]
        [HttpPost]
        public IActionResult CreateTimeSchedule(CreateTimeScheduleModel model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState.Errors());
            }
            var check = _scheduleService.GetById(model.ScheduleId);
            if (check == null)
            {
                return StatusCode(400, new { message = "Schedule not found" });

            }
            var time = new TimeSchedule()
            {
                CreatedDate = DateTime.Now,
                StartTime = model.StartTime,
                ScheduleId = check.Id
            };
            var result = _scheduleService.CreateTimeSchedule(time);
            if (result != null)
            {
                return StatusCode(200, new { status = true });
            }
            return StatusCode(400, new { message = Constant.ResponseMessage.ERROR });
        }

        [Route("admin/schedule/time/delete/", Name = "admin.schedule.time.delete")]
        [HttpPost]
        public IActionResult DeleteTimSchedule(int id)
        {
            var time = _scheduleService.GetTimeScheduleById(id);
            if (time == null)
            {
                TempData["message"] = "Schedules not found";
                return RedirectToAction("Index");
            }
            var result = _scheduleService.RemoveTimeSchedule(time);
            if (result == true)
            {
                TempData["message"] = "Remove success!";
            }
            else
            {
                TempData["message"] = "Remove Erros!";
            }
            return RedirectToAction("Index");
        }
    }
}
