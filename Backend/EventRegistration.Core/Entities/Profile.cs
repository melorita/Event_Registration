using System;

namespace EventRegistration.Core.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
