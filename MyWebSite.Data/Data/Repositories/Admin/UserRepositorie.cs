using Microsoft.EntityFrameworkCore;
using MyWebSite.Domain.Entities.Admin;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Domain.Interface.Repositories.Admin
{
    public class UserRepositorie : BaseRepositories<User>, IUserRepositorie
    {
        private readonly MyWebSiteContext _context;
        public UserRepositorie(MyWebSiteContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> FindByEmailAsync(string email)
        {
           return  await _context.Users.Where(x => x.Email.ToLower().Trim().Equals(email.ToLower().Trim())).FirstAsync();
        }
    }
}
