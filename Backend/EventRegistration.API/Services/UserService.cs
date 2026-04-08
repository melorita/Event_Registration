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

        public async Task<User> RegisterAsync(User user, string password)
        {
            if (await UserExists(user.Email)) return null;

            user.Email = user.Email.ToLower();
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

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }
    }
}
