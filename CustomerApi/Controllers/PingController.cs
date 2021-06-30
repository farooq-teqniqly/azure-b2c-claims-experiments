using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            return this.Ok(DateTime.UtcNow);
        }
    }
}
