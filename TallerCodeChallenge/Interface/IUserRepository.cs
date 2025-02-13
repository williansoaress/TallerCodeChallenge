using TallerCodeChallenge.Models;

namespace TallerCodeChallenge.Interface
{
    public interface IUserRepository
    {
        Task<User> GetByUsername(string username);
    }
}
