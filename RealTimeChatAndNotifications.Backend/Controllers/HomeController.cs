using Microsoft.AspNetCore.Mvc;

namespace RealTimeChatAndNotifications.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Get()
        {
            return Ok();
        }
    }
}