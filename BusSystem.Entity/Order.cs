using BusSystem.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class Order : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserId { get; set; }
        [Column(TypeName = "decimal(18,1)")]

        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(18,1)")]

        public decimal Total { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }
        public int CustomerId { get; set; }
        public int BusCheduleId { get; set; }
        public int TransactionId { get; set; }

        [ForeignKey(nameof(TransactionId))]
        public virtual TransactionHis TransactionHis { get; set; }


        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(BusCheduleId))]
        public virtual BusSchedule BusSchedule { get; set; }


        public virtual Ticket Ticket { get; set; }

        public string GetFullName => Customer?.FullName;
        public string GetPhone => Customer?.Phone;
        public string GetFrom => BusSchedule?.GetFrom;
        public string GetTo => BusSchedule?.GetTo;

        public string GetBusName => BusSchedule?.GetBusName;
        public DateTime? GetStartTime => BusSchedule?.GetStartTime;
        public string GetCode => Ticket?.Code;
        public int? TicketStatus => Ticket?.Status;
        public string GetUserName => User?.UserName;


    }
}
