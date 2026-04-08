using System;

namespace EventRegistration.Core.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PaymentReceiptImage { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    }
}
