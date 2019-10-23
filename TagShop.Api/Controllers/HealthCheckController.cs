using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// Swagger - HealthCheck
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : BaseController
    {
        /// <summary>
        /// Returns the current date and time
        /// </summary>
        /// <returns>String Value</returns>

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Health Check Running: " + DateTime.Now.ToString();
        }
    }
}