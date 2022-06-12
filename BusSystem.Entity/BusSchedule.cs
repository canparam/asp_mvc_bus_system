using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class BusSchedule : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TimeScheduleId { get; set; }
        public int BusId { get; set; }
        [Column(TypeName = "decimal(18,1)")]
        public decimal PriceTicket { get; set; }

        public int Status { get; set; }

        [ForeignKey(nameof(TimeScheduleId))]
        public virtual TimeSchedule TimeSchedule { get; set; }

        [ForeignKey(nameof(BusId))]
        public virtual Bus Bus { get; set; }

        public List<Order> Orders { get; set; }

        public DateTime? GetStartTime => (DateTime)(TimeSchedule?.StartTime);

        public int? GetTotalTicket => Orders.Count;
        public string GetBusName => Bus.Name;
        public int? GetNumberPassengers => Bus.Quantity;

        public string GetFrom => TimeSchedule?.Schedule?.From;
        public string GetTo => TimeSchedule?.Schedule?.To;

        public int? GetBusId => Bus.Id;
        public int? GetScheduleId => TimeSchedule?.Schedule.Id;
        public int? GetTimeScheduleId => TimeSchedule?.Id;

    }
}
