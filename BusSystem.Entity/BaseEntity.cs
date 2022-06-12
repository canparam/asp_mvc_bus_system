using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusSystem.Entity
{
    public class BaseEntity
    {
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; }
        [DefaultValue(0)]
        public int IsDel { get; set; }
    }
}
