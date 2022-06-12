using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.Schedule
{
    public class CreateScheduleModel
    {
        [Required(ErrorMessage = "From is required")]

        public string From { get; set; }
        [Required(ErrorMessage = "To is required")]

        public string To { get; set; }
        [Required(ErrorMessage = "Status is required")]

        public int Status { get; set; }
    }
}
