namespace EventRegistrationDesktop.Models
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }

    public class UserDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }

    public class ProfileUpdateDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ProfilePictureUrl { get; set; }
    }

    // This matches the Profile entity returned by the API
    public class UserProfileResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserInfo User { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ProfilePictureUrl { get; set; }
    }

    public class UserInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
