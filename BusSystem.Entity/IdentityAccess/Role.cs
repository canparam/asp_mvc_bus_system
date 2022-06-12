using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity.IdentityAccess
{
    [Table("AspNetRoles")]
    public class Role :  IdentityRole<string>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
