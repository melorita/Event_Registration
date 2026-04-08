using System;

namespace EventRegistration.Core.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; } // e.g., "RegistrationSummary", "UserActivity"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int GeneratedByUserId { get; set; }
        public User GeneratedByUser { get; set; }
    }
}
