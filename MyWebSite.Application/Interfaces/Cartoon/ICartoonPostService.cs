using MyWebSite.Application.Commands;
using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces;
using MyWebSite.Domain.Entities.Cartoon;

namespace MyWebSite.Application.Interfaces.Cartoon
{
    public interface ICartoonPostService : ICommumService
    {
        Task AddPostAsync(AddCartoonCategoryCommand cartoonPost);
        Task<CartoonPostDto> GetPostByIdAsync(Guid id);
        Task AddCategory(AddCartoonCategoryInPostCartoonCommand addCartoonCategoryInPostCartoonCommand);
        Task UpdatePostAsync(UpdateCartoonPostCommand cartoonPost);
        Task<IEnumerable<CartoonPostDto>> GetAllPostsAsync();
        Task<IEnumerable<CartoonPostDto>> GetAllActivePostsAsync();
        Task<IEnumerable<CartoonPostDto>> GetCartoonByCategoryAsync(Guid idCategory);

    }
}
