using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteSkillDesciptionService : ICommumService
    {
        Task UpdateImage(UpdateImageCommand updateImageCommand);
        Task UpdateSkillDescriptionAsync(UpdateWebSiteSkillDescriptionCommand updateWebSiteSkillDescriptionCommand);
        Task AddSkillDescriptionAsync(AddWebSiteSkillDescriptionCommand webSiteSkillDescription);
        Task<IEnumerable<WebSiteSkillDescriptionDto>> GetSocialMediasActiveAsync();
        Task<IEnumerable<WebSiteSkillDescriptionDto>> GetSocialMediasAsync();
        Task<WebSiteSkillDescriptionDto> GetSocialMediaByIdAsync(Guid id);
    }
}
