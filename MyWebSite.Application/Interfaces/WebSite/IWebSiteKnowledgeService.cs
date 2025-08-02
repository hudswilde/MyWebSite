using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteKnowledgeService : ICommumService
    {
        Task AddknowledgesAsync(AddWebSiteknowledgesCommand addWebSiteknowledgesCommand);
        Task AlterknowledgesAsync(UpdateWebSiteknowledgesCommand updateWebSiteknowledgesCommand);
        Task<IEnumerable<WebSiteknowledgeDto>> GetKnowledgesActiveAsync();
        Task<IEnumerable<WebSiteknowledgeDto>> GetKnowledgesAsync();
        Task<WebSiteknowledgeDto> GetKnowledgeByIdAsync(Guid id);

    }
}
