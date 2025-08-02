namespace MyWebSite.Application.Dtos
{
    public record UpdateWebSiteSkillDescriptionCommand(Guid Id,string Title, string Summary, string Description);
    
}
