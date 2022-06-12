using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model
{
    public abstract class BaseModel
    {
        //public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
