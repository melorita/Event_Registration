using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
            var email = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            
            var profile = await _context.Profiles
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.User.Email == email);

            if (profile == null) return NotFound();

            // Strip out sensitive info for the demo if needed, but here we return the whole profile
            return profile;
        }
    }
}
