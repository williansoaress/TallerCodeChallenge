using Microsoft.EntityFrameworkCore;
using TallerCodeChallenge.Context;
using TallerCodeChallenge.Interface;
using TallerCodeChallenge.Models;

namespace TallerCodeChallenge.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<User> DbSet;

        public UserRepository(AppDbContext db)
        {
            Db = db;
            DbSet = db.Set<User>();
        }

        public async Task<User> GetByUsername(string username)
        {
            return await Db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
