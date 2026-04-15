using System.Threading.Tasks;
using EventRegistration.API.DTOs;
using EventRegistration.API.Services;
using EventRegistration.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistration.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public AccountController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            try
            {
                var user = new User
                {
                    FullName = registerDto.FullName,
                    Email = registerDto.Email,
                    Profile = new Profile
                    {
                        PhoneNumber = registerDto.PhoneNumber,
                        Gender = registerDto.Gender,
                        Address = registerDto.Address,
                        ProfilePictureUrl = string.Empty
                    }
                };

                var registeredUser = await _userService.RegisterAsync(user, registerDto.Password);

                if (registeredUser == null) return BadRequest("Email is already taken");

                return new UserDto
                {
                    Email = registeredUser.Email,
                    FullName = registeredUser.FullName,
                    Token = _tokenService.CreateToken(registeredUser),
                    Role = registeredUser.Role
                };
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Registration Internal Error: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userService.AuthenticateAsync(loginDto.Email, loginDto.Password);

            if (user == null) return Unauthorized("Invalid email or password");

            return new UserDto
            {
                Email = user.Email,
                FullName = user.FullName,
                Token = _tokenService.CreateToken(user),
                Role = user.Role
            };
        }
    }
}
