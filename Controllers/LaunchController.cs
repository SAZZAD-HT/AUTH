using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ispat.Controllers
{
    [ApiController]
    [Route("Copyright")]
    [Route("")]
    public class LaunchController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Copyright Reserved"
        };

        private readonly ILogger<LaunchController> _logger;

        public LaunchController(ILogger<LaunchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Array Get()
        {
            throw new UnauthorizedAccessException();
            var rng = new Random();
            return Summaries;
        }
    }
}
