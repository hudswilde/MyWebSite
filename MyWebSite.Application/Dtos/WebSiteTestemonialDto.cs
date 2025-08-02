namespace MyWebSite.Application.Dtos
{
    public record WebSiteTestemonialDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring, 
    string Name, 
    string Description,
    IEnumerable<ImageDto>? Images,
    string Role,
    string Font);
    
}
