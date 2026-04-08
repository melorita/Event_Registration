using Microsoft.AspNetCore.Mvc;
using EventRegistration.API.DTOs;
using System.Threading.Tasks;

namespace EventRegistration.API.Controllers.v1
{
    public class AccountController : BaseApiController
    {
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            // Placeholder for login logic
            return Ok(new UserDto { Email = loginDto.Email, FullName = "Placeholder User", Token = "JWT_Token_Here" });
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            // Placeholder for register logic
            return Ok(new UserDto { Email = registerDto.Email, FullName = registerDto.FullName, Token = "JWT_Token_Here" });
        }
    }
}
