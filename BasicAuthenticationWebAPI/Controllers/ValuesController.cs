using BasicAuthenticationWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace BasicAuthenticationWebAPI.Controllers
{
    [BasicAuthentication]
  
    public class ValuesController : ApiController
    {
        [Route("api/employees")]
        public HttpResponseMessage GetEmployees()
        {
            Employees emp = new Employees();

            string username = Thread.CurrentPrincipal.Identity.Name;
            if (username == "CoreProgramm")
            {
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    "Unauthorized User");
            }
        }
    }
}
