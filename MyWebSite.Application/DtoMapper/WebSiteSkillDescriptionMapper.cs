using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Application.DtoMapper
{
    public static class WebSiteSkillDescriptionMapper
    {
        public static WebSiteSkillDescriptionDto ToDto(this WebSiteSkillDescription webSiteSkillDescription)
        {
            return new WebSiteSkillDescriptionDto(webSiteSkillDescription.Id, webSiteSkillDescription.IsActive, webSiteSkillDescription.CreatedDate, webSiteSkillDescription.UpdateDate, webSiteSkillDescription.Title, webSiteSkillDescription.Summary, webSiteSkillDescription.Description,webSiteSkillDescription.Images.Select(x=> x.ToDto()));
        }
    }
}
