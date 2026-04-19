using System.Threading.Tasks;
using EventRegistration.API.DTOs;
using EventRegistration.Core.Entities;
using EventRegistration.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EventRegistration.API.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            var user = await _context.Users
                .Include(u => u.Profile)
                .SingleOrDefaultAsync(x => x.Email == email.ToLower());

            if (user == null) return null;

            if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                return null;

            return user;
        }

        public async Task<bool> ChangePasswordAsync(string email, string currentPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
                return false;

            currentPassword = currentPassword.Trim();
            newPassword = newPassword.Trim();

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == email.ToLower());
            if (user == null) return false;

            if (!BCrypt.Net.BCrypt.Verify(currentPassword, user.Password))
                return false;

            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<User> RegisterAsync(User user, string password)
        {
            if (string.IsNullOrWhiteSpace(user.Email)) return null;
            
            user.Email = user.Email.Trim().ToLower();
            if (await UserExists(user.Email)) return null;

            user.Password = BCrypt.Net.BCrypt.HashPassword(password);
            
            // Default role if not set
            if (string.IsNullOrEmpty(user.Role))
            {
                user.Role = "Participant";
            }

            // Create or update initial profile
            if (user.Profile == null)
            {
                user.Profile = new Profile();
            }
            
            user.Profile.UpdatedAt = System.DateTime.UtcNow;

            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Database error during registration: " + ex.Message, ex);
            }

            return user;
        }

        private async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }
    }
}
