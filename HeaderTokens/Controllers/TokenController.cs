using HeaderTokens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HeaderTokens.Controllers
{
    public class TokenController : ApiController
    {
        Output output;
        public HttpResponseMessage Post(Token1 value)
        {
            output = new Output();
            output.ResponseMessage = Request.Headers.GetValues("Token").FirstOrDefault();
            output.Data = value;
            return Request.CreateResponse(HttpStatusCode.OK, output, "application/json");
        }
    }
}
