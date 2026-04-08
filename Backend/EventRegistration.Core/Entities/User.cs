using System;
using System.Collections.Generic;

namespace EventRegistration.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Participant, Admin
        public Profile Profile { get; set; }
        public List<Registration> Registrations { get; set; } = new List<Registration>();
        public List<Report> Reports { get; set; } = new List<Report>();
    }
}
