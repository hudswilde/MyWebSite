using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces;
using MyWebSite.Domain.Entities;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteGeralService : ICommumService
    {
        Task AlterImageAsync(UpdateWebSiteImageGeralCommand updateWebSiteImageGeralCommand);
        Task AlterFieldsAsync(UpdateWebSiteGeralCommand updateWebSiteGeralCommand);
        Task<IEnumerable<WebSiteGeralDto>> GetWebSiteGeralActiveAsync();
        Task<IEnumerable<WebSiteGeralDto>> GetWebSiteGeralAsync();
        Task<WebSiteGeralDto> GetWebSiteGeralByIdAsync(Guid id);
    }
}
