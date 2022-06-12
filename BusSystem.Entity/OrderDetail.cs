using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class OrderDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        [Column(TypeName = "decimal(18,1)")]
        public decimal Price { get; set; }

        public DateTime StartTime { get; set; }
        public string BusName { get; set; }
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        public decimal GetTotal => Order.Total;
        public decimal GetAmount => Order.Amount;
        public int GetDiscount => Order.Discount;
        public int GetOrderStatus => Order.Status;

        public string GetFullName => Order.GetFullName;
        public string GetPhone => Order.GetPhone;
        public string GetCode => Order.GetCode;
        public int? TicketStatus => Order.TicketStatus;
        public string GetUserName => Order.GetUserName;

        public DateTime? GetOrderCreateDate => Order?.CreatedDate;
    }
}
