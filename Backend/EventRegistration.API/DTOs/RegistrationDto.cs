using System;

namespace EventRegistration.API.DTOs
{
    public class CreateRegistrationDto
    {
        public int EventId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class RegistrationDto
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string EventDate { get; set; }
        public string EventLocation { get; set; }
    }
}
