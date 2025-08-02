using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteTestemonialService : ICommumService
    {
        Task UpdateImage(UpdateImageCommand updateImageCommand);
        Task AddTestemonialAsync(AddWebSiteSocialMediaCommand addWebSiteSocialMediaCommand);
        Task UpdateTestemonialAsync(UpdateWebSiteSocialMediaCommand updateWebSiteSocialMediaCommand);
        Task<IEnumerable<WebSiteTestemonialDto>> GetTestemonialsActiveAsync();
        Task<IEnumerable<WebSiteTestemonialDto>> GetTestemonialsAsync();
        Task<WebSiteTestemonialDto> GetTestemonialByIdAsync(Guid id);

    }
}
