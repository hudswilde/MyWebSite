using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.Blog
{
    public interface IBlogPostService : ICommumService
    {
        Task AddPostAsync(AddBlogPostCommand blogPost);
        Task AddCategory(AddBlogCategoryInPostBlogCommand addBlogCategoryInPostBlogCommand);
        Task<BlogPostDto> GetPostByIdAsync(Guid id);
        Task UpdatePostAsync(UpdateBlogpostCommand blogPost);
        Task<IEnumerable<BlogPostDto>> GetAllPostsAsync();
        Task<IEnumerable<BlogPostDto>> GetActiveAllPostsAsync();
        Task<IEnumerable<BlogPostDto>> GetPostsByCategoryAsync(Guid idCategory);

    }
}
