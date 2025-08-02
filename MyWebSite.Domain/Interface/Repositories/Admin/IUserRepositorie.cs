using MyWebSite.Domain.Entities.Admin;

namespace MyWebSite.Domain.Interface.Repositories.Admin
{
    public interface IUserRepositorie : IBaseRepositories<User>
    {
        Task<User> FindByEmailAsync(string email);

    }
}
