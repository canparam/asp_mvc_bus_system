using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class Schedule : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public int Status { get; set; }

        public virtual List<TimeSchedule> TimeSchedules { get; set; }

        public int? GetCountTime => TimeSchedules?.Count ?? 0;
    }
}
