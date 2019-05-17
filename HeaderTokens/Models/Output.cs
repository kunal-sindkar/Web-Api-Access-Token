using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeaderTokens.Models
{
    public class Output
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public object Data { get; set; }
    }
}