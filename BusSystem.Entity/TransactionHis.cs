using BusSystem.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class TransactionHis : BaseEntity
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("user_id")]
        public string UserId { get; set; }
        [Column("credit", TypeName = "decimal(18,1)")]
        public decimal Credit { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("type")]
        public int Type { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }

        public string Message { get; set; }

        public DateTime GetCreatedAt => CreatedDate;
        public string GetCreateBy => CreatedBy;

        public string GetReceiverName => User?.UserName;
    }
}
