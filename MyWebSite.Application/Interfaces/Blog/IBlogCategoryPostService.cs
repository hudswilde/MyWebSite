using MyWebSite.Application.Commands;
using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities.Blog;

namespace MyWebSite.Application.Interfaces.Blog
{
    public interface IBlogCategoryPostService : ICommumService
    {
        Task AddCategoryPostAsync(AddBlogCategoryCommand blogCategory);
        Task<BlogCategoryPostDto> GetCategoryBlogByIdAsync(Guid id);
        Task UpdateCategoryAsync(UpdateBlogCategoryCommand blogCategory);
        Task<IEnumerable<BlogCategoryPostDto>> GetAllCategoryAsync();
    }
}
