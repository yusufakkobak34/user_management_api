using System.Net;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace user_management.Controllers
{
    [ApiController]
    [Route("api/v1/authenticate")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [ProducesResponseType((int)HttpStatusCode.OK, typeof(LoginResponse))]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {

        }
    }
}

