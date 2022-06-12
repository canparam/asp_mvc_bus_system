using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Response
{
    public class JsonSuccessModel
    {
        public int StatusCode { get; set; }
        public dynamic Data { get; set; }
    }
}
