using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.WebSite
{
    public interface IWebSiteSkillService : ICommumService
    {
        Task AddSkillAsync(AddWebSiteSkillCommand addWebSiteSkill);
        Task UpdateSkillAsync(UpdateWebSiteSkillCommand addWebSiteSkill);
        Task<IEnumerable<WebSiteSkillDto>> GetSocialMediasActiveAsync();
        Task<IEnumerable<WebSiteSkillDto>> GetSocialMediasAsync();
        Task<WebSiteSkillDto> GetSocialMediaByIdAsync(Guid id);
    }
}
