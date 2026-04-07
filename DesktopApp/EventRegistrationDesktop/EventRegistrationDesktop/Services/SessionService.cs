using System;

namespace EventRegistrationDesktop.Services
{
    public static class SessionService
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string UserName { get; set; } = string.Empty;
        public static string UserEmail { get; set; } = string.Empty;
        public static string UserRole { get; set; } = string.Empty;

        public static void Login(string name, string email, string role)
        {
            IsLoggedIn = true;
            UserName = name;
            UserEmail = email;
            UserRole = role;
        }

        public static void Logout()
        {
            IsLoggedIn = false;
            UserName = string.Empty;
            UserEmail = string.Empty;
            UserRole = string.Empty;
        }
    }
}
