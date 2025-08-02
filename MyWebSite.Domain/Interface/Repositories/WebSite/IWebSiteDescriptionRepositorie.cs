using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Domain.Interface.Repositories.WebSite
{
    public interface IWebSiteDescriptionRepositorie : IBaseRepositories<WebSiteDescription>
    {
        Task<IEnumerable<WebSiteDescription>> GetAllActiveAsync();
    }
}
