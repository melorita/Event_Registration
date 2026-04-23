using EventRegistration.Core.Entities;
using EventRegistration.Infrastructure.Data;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;

namespace EventRegistration.API.Services
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Seed Users
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        FullName = "Admin User",
                        Email = "admin@ethioevents.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                        Role = "Admin",
                        Profile = new Profile { Bio = "System Administrator", UpdatedAt = System.DateTime.UtcNow }
                    },
                    new User
                    {
                        FullName = "Test Participant",
                        Email = "test@example.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Test@123"),
                        Role = "Participant",
                        Profile = new Profile { Bio = "Regular Participant", UpdatedAt = System.DateTime.UtcNow }
                    }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            // Seed Events
            if (!context.Events.Any())
            {
                var events = new List<Event>
                {
                    new Event
                    {
                        EventName = "Tech Conference 2026",
                        Description = "The biggest tech gathering in Addis Ababa.",
                        Date = System.DateTime.Now.AddDays(30),
                        Location = "Millennium Hall",
                        Capacity = 500,
                        Category = "Technology",
                        Organizer = "Ethio Tech",
                        EventImage = "https://images.unsplash.com/photo-1540575861501-7ad05823c95b?q=80&w=2070"
                    },
                    new Event
                    {
                        EventName = "Cultural Music Festival",
                        Description = "A celebration of Ethiopian heritage through music and dance.",
                        Date = System.DateTime.Now.AddDays(15),
                        Location = "Ghion Hotel",
                        Capacity = 300,
                        Category = "Culture",
                        Organizer = "Habesha Arts",
                        EventImage = "https://images.unsplash.com/photo-1514525253344-99a4299966c2?q=80&w=1974"
                    }
                };
                context.Events.AddRange(events);
                context.SaveChanges();
            }
        }
    }
}
