using Microsoft.AspNetCore.Mvc;

namespace maddybackend.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class ProjectDetailsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = new[]
            {
            new { name = "Baking Website", description = "A website to rate and share recipes", link = "https://github.com/nklinh0511/BakingWebsite" }
        };
            return Ok(projects);
        }
    }

}
