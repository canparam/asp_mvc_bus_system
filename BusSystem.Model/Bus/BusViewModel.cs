using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Bus
{
    public class BusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
