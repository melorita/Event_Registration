using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EventRegistration.API.DTOs;
using EventRegistration.Core.Entities;
using EventRegistration.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventRegistration.API.Controllers
{
    [Authorize]
    public class ProfilesController : BaseApiController
    {
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("me")]
        public async Task<ActionResult<Profile>> GetMyProfile()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value ?? User.FindFirst("nameid")?.Value;
            
            var profile = await _context.Profiles
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.User.Email == email);

            if (profile == null) return NotFound();

            return profile;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProfile(ProfileUpdateDto profileUpdateDto)
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value ?? User.FindFirst("nameid")?.Value;
            
            var profile = await _context.Profiles
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.User.Email == email);

            if (profile == null) return NotFound();

            profile.User.FullName = profileUpdateDto.FullName;
            profile.PhoneNumber = profileUpdateDto.PhoneNumber;
            profile.Gender = profileUpdateDto.Gender;
            profile.Address = profileUpdateDto.Address;
            profile.ProfilePictureUrl = profileUpdateDto.ProfilePictureUrl;
            profile.UpdatedAt = System.DateTime.UtcNow;

            if (await _context.SaveChangesAsync() > 0) return NoContent();

            return BadRequest("Failed to update profile");
        }
    }
}
