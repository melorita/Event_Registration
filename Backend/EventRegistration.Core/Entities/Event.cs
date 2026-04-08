using System;
using System.Collections.Generic;

namespace EventRegistration.Core.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Category { get; set; }
        public string Organizer { get; set; }
        public string EventImage { get; set; }
        public List<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
