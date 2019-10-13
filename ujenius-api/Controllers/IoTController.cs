using Microsoft.AspNetCore.Mvc;

namespace ujenius_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class IoTController : Controller
    {
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
