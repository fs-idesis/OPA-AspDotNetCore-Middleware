using Build.Security.AspNetCore.Middleware.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace SampleApplication.Controllers
{
    [ApiController]
    [Route("project/{id}")]
    public class ProjectController : Controller
    {
        [HttpGet]
        [Authorize("project.view")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        [Authorize("project.create")]
        public IActionResult Create()
        {
            return Accepted();
        }
    }
}
