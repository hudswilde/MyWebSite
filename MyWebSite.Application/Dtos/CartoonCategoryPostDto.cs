namespace MyWebSite.Application.Dtos
{
    public record CartoonCategoryPostDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring, 
    string Name);
    
}
