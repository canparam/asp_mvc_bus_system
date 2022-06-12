using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.TimeSchedule
{
    public class CreateTimeScheduleModel
    {


        [Required(ErrorMessage = "StartTime is required")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "ScheduleId is required")]
        public int ScheduleId { get; set; }
    }
}
