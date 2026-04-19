using System.Collections.Generic;
using System.Threading.Tasks;
using EventRegistration.Core.Entities;

namespace EventRegistration.API.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string email, string password);
        Task<User> RegisterAsync(User user, string password);
        Task<bool> ChangePasswordAsync(string email, string currentPassword, string newPassword);
    }
}
