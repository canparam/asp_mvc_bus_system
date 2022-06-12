using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.BusSchedule
{
    public class CreateBusScheduleModel
    {
        [Required(ErrorMessage = "Bus is required")]
        public int? BusId { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Schedule is required")]
        public int? ScheduleId { get; set; }
        [Required(ErrorMessage = "Schedule Time is required")]
        public int? ScheduleTimeId { get; set; }
        public int Status { get; set; }


    }
}
