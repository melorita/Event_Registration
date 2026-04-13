using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventRegistration.API.DTOs;
using EventRegistration.Core.Entities;
using EventRegistration.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventRegistration.API.Controllers
{
    public class EventsController : BaseApiController
    {
        private readonly AppDbContext _context;

        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetEvents()
        {
            return await _context.Events
                .Select(e => new EventDto
                {
                    Id = e.Id,
                    EventName = e.EventName,
                    Description = e.Description,
                    Date = e.Date,
                    Location = e.Location,
                    Capacity = e.Capacity,
                    Category = e.Category,
                    Organizer = e.Organizer,
                    EventImage = e.EventImage
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventDto>> GetEvent(int id)
        {
            var e = await _context.Events.FindAsync(id);

            if (e == null) return NotFound();

            return new EventDto
            {
                Id = e.Id,
                EventName = e.EventName,
                Description = e.Description,
                Date = e.Date,
                Location = e.Location,
                Capacity = e.Capacity,
                Category = e.Category,
                Organizer = e.Organizer,
                EventImage = e.EventImage
            };
        }

        [HttpPost]
        public async Task<ActionResult<EventDto>> CreateEvent(CreateEventDto createEventDto)
        {
            var @event = new Event
            {
                EventName = createEventDto.EventName,
                Description = createEventDto.Description,
                Date = createEventDto.Date,
                Location = createEventDto.Location,
                Capacity = createEventDto.Capacity,
                Category = createEventDto.Category,
                Organizer = createEventDto.Organizer,
                EventImage = createEventDto.EventImage
            };

            _context.Events.Add(@event);
            
            if (await _context.SaveChangesAsync() > 0)
            {
                return CreatedAtAction(nameof(GetEvent), new { id = @event.Id }, new EventDto
                {
                    Id = @event.Id,
                    EventName = @event.EventName,
                    Description = @event.Description,
                    Date = @event.Date,
                    Location = @event.Location,
                    Capacity = @event.Capacity,
                    Category = @event.Category,
                    Organizer = @event.Organizer,
                    EventImage = @event.EventImage
                });
            }

            return BadRequest("Problem creating event");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEvent(int id, CreateEventDto updateEventDto)
        {
            try
            {
                var @event = await _context.Events.FindAsync(id);

                if (@event == null) return NotFound($"Event with ID {id} not found");

                @event.EventName = updateEventDto.EventName;
                @event.Description = updateEventDto.Description;
                @event.Date = updateEventDto.Date;
                @event.Location = updateEventDto.Location;
                @event.Capacity = updateEventDto.Capacity;
                @event.Category = updateEventDto.Category;
                @event.Organizer = updateEventDto.Organizer;
                @event.EventImage = updateEventDto.EventImage;

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (System.Exception ex)
            {
                return BadRequest("Error updating event: " + ex.Message + (ex.InnerException != null ? " | Inner: " + ex.InnerException.Message : ""));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id);

            if (@event == null) return NotFound();

            _context.Events.Remove(@event);

            if (await _context.SaveChangesAsync() > 0) return Ok();

            return BadRequest("Problem deleting event");
        }
    }
}
