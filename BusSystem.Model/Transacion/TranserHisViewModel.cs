using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Transacion
{
    public class TranserHisViewModel
    {
        public int? Id { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal? Credit { get; set; }
        public string CreateBy { get; set; }
        public string ReceiverName { get; set; }
        public string Message { get; set; }
    }
}
