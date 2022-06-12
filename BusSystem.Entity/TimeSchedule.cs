using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class TimeSchedule : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ScheduleId { get; set; }

        public DateTime StartTime { get; set; }

        public int Status { get; set; }

        [ForeignKey(nameof(ScheduleId))]
        public virtual Schedule Schedule { get; set; }
    }
}
