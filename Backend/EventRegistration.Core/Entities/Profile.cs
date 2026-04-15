using System;

namespace EventRegistration.Core.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
