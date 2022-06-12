using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class Ticket : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        public string GetFrom => Order?.BusSchedule?.GetFrom;
        public string GetTo => Order?.BusSchedule?.GetTo;
        public DateTime? StartTime => Order?.BusSchedule?.GetStartTime;
    }
}
