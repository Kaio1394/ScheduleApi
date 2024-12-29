using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public ILogger<AuthController> _logger { get; }

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
    }
}
