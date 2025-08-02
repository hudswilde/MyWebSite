using MyWebSite.Domain.Entities.Blog;

namespace MyWebSite.Application.Dtos
{
    public record BlogPostDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring, 
    string Title, 
    string SubTitle,
    IEnumerable<ImageDto>? Images, 
    string Description,
    IEnumerable<BlogCategoryPost> ListCategoryPost);
    
}
