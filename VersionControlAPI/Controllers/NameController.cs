
using Microsoft.AspNetCore.Mvc;

namespace VersionControlAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        // Eric Reynolds
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { Name = "Eric Reynolds" });
        }
    }
}
