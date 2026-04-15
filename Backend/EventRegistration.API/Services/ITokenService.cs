using System.Threading.Tasks;
using EventRegistration.Core.Entities;

namespace EventRegistration.API.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
