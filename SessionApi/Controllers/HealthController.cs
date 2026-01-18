using Microsoft.AspNetCore.Mvc;

namespace SessionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("API Healthy - Free Tier Session Platform");
    }
}
