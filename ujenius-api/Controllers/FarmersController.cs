using Microsoft.AspNetCore.Mvc;
using ujenius_api.Orchestration;

namespace ujenius_api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class FarmersController : Controller
    {
        private readonly IDataOrchestration _Data;

        public FarmersController(IDataOrchestration data)
        {
            _Data = data;
        }

        // GET api/values
        [HttpGet]
        [Route("farmers")]
        public ActionResult GetFarmers()
        {
            return Ok(_Data.GetFarmers());
        }

        



    }
}
