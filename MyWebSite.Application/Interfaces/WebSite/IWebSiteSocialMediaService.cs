using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteSocialMediaService : ICommumService
    {
        Task UpdateImage(UpdateImageCommand updateImageCommand);
        Task AddSocialMediaAsync(AddWebSiteSocialMediaCommand addWebSiteSocialMediaCommand);
        Task UpdateSocialMediaAsync(UpdateWebSiteSocialMediaCommand updateWebSiteSocialMediaCommand);
        Task<IEnumerable<WebSiteSocialMediaDto>> GetSocialMediasActiveAsync();
        Task<IEnumerable<WebSiteSocialMediaDto>> GetSocialMediasAsync();
        Task<WebSiteSocialMediaDto> GetSocialMediaByIdAsync(Guid id);
    }
}
