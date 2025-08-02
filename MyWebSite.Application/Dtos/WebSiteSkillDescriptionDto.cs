namespace MyWebSite.Application.Dtos
{
    public record WebSiteSkillDescriptionDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring, 
    string Title, 
    string Summary, 
    string Description,
    IEnumerable<ImageDto>? Images);
    
}
