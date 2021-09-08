using BusinessAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenciesTest.Web.Controllers
{
    [Route("api/di")]
    [ApiController]
    public class DependencyInversionController : ControllerBase
    {

        [HttpGet("/demo")]
        public IActionResult Demo()
        {
            Coordinator coordinator = new Coordinator();
            coordinator.InitializeServicesForBusiness();

            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.DemoServicesUsage();

            return new OkResult();
        }

    }
}
