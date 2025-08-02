using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record AddWebSiteSkillDescriptionCommand(string Title, string Summary, string Description, ImageDto Thumb);
    
}
