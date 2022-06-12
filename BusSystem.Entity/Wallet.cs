using BusSystem.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class Wallet : BaseEntity
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("user_id")]
        public string UserId { get; set; }
        [Column("amount", TypeName = "decimal(18,1)")]
        public decimal Amount { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
