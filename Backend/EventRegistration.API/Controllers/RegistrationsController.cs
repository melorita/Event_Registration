using System.Collections.Generic;
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
    public class RegistrationsController : BaseApiController
    {
        private readonly AppDbContext _context;

        public RegistrationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/registrations/my  – registrations for the logged-in user
        [HttpGet("my")]
        public async Task<ActionResult<IEnumerable<RegistrationDto>>> GetMyRegistrations()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value
                     ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var regs = await _context.Registrations
                .Include(r => r.Event)
                .Include(r => r.User)
                .Where(r => r.User.Email == email)
                .Select(r => new RegistrationDto
                {
                    Id            = r.Id,
                    EventId       = r.EventId,
                    EventName     = r.Event.EventName,
                    FullName      = r.FullName,
                    Email         = r.Email,
                    Status        = r.Status,
                    RegisteredAt  = r.RegisteredAt,
                    EventDate     = r.Event.Date.ToString("MMM dd, yyyy"),
                    EventLocation = r.Event.Location
                })
                .ToListAsync();

            return regs;
        }

        // GET /api/registrations  – all registrations (Admin only)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrationDto>>> GetAllRegistrations()
        {
            var regs = await _context.Registrations
                .Include(r => r.Event)
                .Include(r => r.User)
                .Select(r => new RegistrationDto
                {
                    Id            = r.Id,
                    EventId       = r.EventId,
                    EventName     = r.Event.EventName,
                    FullName      = r.FullName,
                    Email         = r.Email,
                    Status        = r.Status,
                    RegisteredAt  = r.RegisteredAt,
                    EventDate     = r.Event.Date.ToString("MMM dd, yyyy"),
                    EventLocation = r.Event.Location
                })
                .ToListAsync();

            return regs;
        }

        // POST /api/registrations  – register the current user for an event
        [HttpPost]
        public async Task<ActionResult<RegistrationDto>> CreateRegistration(CreateRegistrationDto dto)
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value
                     ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null) return Unauthorized();

            var ev = await _context.Events.FindAsync(dto.EventId);
            if (ev == null) return NotFound("Event not found");

            // Prevent duplicate registrations
            bool exists = await _context.Registrations
                .AnyAsync(r => r.UserId == user.Id && r.EventId == dto.EventId);
            if (exists) return BadRequest("You have already registered for this event.");

            var reg = new Registration
            {
                UserId       = user.Id,
                EventId      = dto.EventId,
                FullName     = dto.FullName,
                Email        = dto.Email,
                Status       = "Pending",
                RegisteredAt = System.DateTime.UtcNow
            };

            _context.Registrations.Add(reg);
            if (await _context.SaveChangesAsync() > 0)
            {
                return CreatedAtAction(nameof(GetMyRegistrations), new { }, new RegistrationDto
                {
                    Id            = reg.Id,
                    EventId       = reg.EventId,
                    EventName     = ev.EventName,
                    FullName      = reg.FullName,
                    Email         = reg.Email,
                    Status        = reg.Status,
                    RegisteredAt  = reg.RegisteredAt,
                    EventDate     = ev.Date.ToString("MMM dd, yyyy"),
                    EventLocation = ev.Location
                });
            }

            return BadRequest("Problem creating registration");
        }

        // PUT /api/registrations/{id}/status  – Admin updates status
        [HttpPut("{id}/status")]
        public async Task<ActionResult> UpdateStatus(int id, [FromBody] string status)
        {
            var reg = await _context.Registrations.FindAsync(id);
            if (reg == null) return NotFound();

            if (status != "Pending" && status != "Approved" && status != "Rejected")
                return BadRequest("Invalid status. Use Pending, Approved, or Rejected.");

            reg.Status = status;
            if (await _context.SaveChangesAsync() > 0) return NoContent();
            return BadRequest("Problem updating status");
        }

        // DELETE /api/registrations/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRegistration(int id)
        {
            var reg = await _context.Registrations.FindAsync(id);
            if (reg == null) return NotFound();

            _context.Registrations.Remove(reg);
            if (await _context.SaveChangesAsync() > 0) return Ok();
            return BadRequest("Problem deleting registration");
        }
    }
}
