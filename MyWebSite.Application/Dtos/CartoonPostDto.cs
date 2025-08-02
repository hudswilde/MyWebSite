namespace MyWebSite.Application.Dtos
{
    public record CartoonPostDto(Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring,
    string Title, 
    string SubTitle,
    IEnumerable<ImageDto>? Images, 
    string Description,
    IEnumerable<CartoonCategoryPostDto> ListCategoryPost);
    
}
