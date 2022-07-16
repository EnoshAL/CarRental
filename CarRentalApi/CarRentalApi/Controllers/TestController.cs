using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarRentalApi.Controllers
{
    [RoutePrefix("Test")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("MyEndpoint")]
        public string test()
        {
            return "Hello";
        }
    }
}