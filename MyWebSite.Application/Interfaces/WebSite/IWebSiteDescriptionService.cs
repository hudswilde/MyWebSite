using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteDescriptionService : ICommumService
    {
        Task AddDescriptionAsync(AddWebSiteDescriptionCommand webSiteDescription);
        Task<WebSiteDescriptionDto> GetDescriptionByIdAsync(Guid id);
        Task AlterDescriptionAsync(UpdateWebSiteDescriptionCommand webSiteDescription);
        Task<IEnumerable<WebSiteDescriptionDto>> GetAllDescriptionAsync();
        Task<IEnumerable<WebSiteDescriptionDto>> GetAllActiveDescriptionAsync();
    }
}
