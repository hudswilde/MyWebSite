namespace MyWebSite.Application.Dtos
{
    public record WebSiteDescriptionDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDate, 
    string Title, 
    string SubTitle, 
    string Description, 
    IEnumerable<WebSiteSkillDescriptionDto> ListSkillDescription);
    
}
