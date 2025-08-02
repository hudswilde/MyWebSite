namespace MyWebSite.Application.Dtos
{
    public record WebSiteSkillDto(Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring,
    float Percent, 
    string Name);
    
}
