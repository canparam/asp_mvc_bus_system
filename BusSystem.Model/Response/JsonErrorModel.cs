using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Model.Response
{
    public class JsonErrorModel
    {
        public int StatusCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
