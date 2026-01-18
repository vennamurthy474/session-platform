using Microsoft.AspNetCore.Mvc;

namespace SessionApi.Controllers
{
    [ApiController]
    [Route("session")]
    public class SessionController : ControllerBase
    {
        [HttpGet("{sessionId}")]
        public IActionResult GetSession(string sessionId)
        {
            return Ok(new
            {
                sessionId,
                status = "active",
                timestamp = DateTime.UtcNow,
                message = "Redis integration coming in Step 4"
            });
        }
    }
}
