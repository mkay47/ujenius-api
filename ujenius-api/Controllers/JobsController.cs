using Microsoft.AspNetCore.Mvc;
using ujenius_api.Orchestration;

namespace ujenius_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly IDataOrchestration _Data;

        public JobsController(IDataOrchestration data)
        {
            _Data = data;
        }

        [HttpGet]
        [Route("jobs")]
        public ActionResult GetJobs()
        {
            return Ok(_Data.GetJobs());
        }
    }
}
