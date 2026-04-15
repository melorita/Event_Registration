using System;

namespace EventRegistrationDesktop.Services
{
    public static class SessionService
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string UserName { get; set; } = string.Empty;
        public static string UserEmail { get; set; } = string.Empty;
        public static string UserRole { get; set; } = string.Empty;
        public static string Token { get; set; } = string.Empty;

        public static void Login(string name, string email, string role, string token)
        {
            IsLoggedIn = true;
            UserName = name;
            UserEmail = email;
            UserRole = role;
            Token = token;
        }

        public static void Logout()
        {
            IsLoggedIn = false;
            UserName = string.Empty;
            UserEmail = string.Empty;
            UserRole = string.Empty;
            Token = string.Empty;
        }
    }
}
