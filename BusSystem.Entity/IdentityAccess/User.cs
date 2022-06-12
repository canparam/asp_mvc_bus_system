using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Entity.IdentityAccess
{
    [Table("AspNetUsers")]
    public class User : IdentityUser<string>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }

        [DefaultValue(0)]
        public int IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual Wallet Wallet { get; set; }
        public virtual List<TransactionHis> TransactionHis { get; set; }
        public decimal? GetAmount => Wallet?.Amount;

       
    }
}
