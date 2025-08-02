using MyWebSite.Application.Commands;
using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces;
using MyWebSite.Domain.Entities.Cartoon;

namespace MyWebSite.Application.Interfaces.Cartoon
{
    public interface ICartoonCategoryPostService : ICommumService
    {
        Task AddPostAsync(AddCartoonCategoryCommand cartoonCategory);
        Task<CartoonCategoryPostDto> GetCategoryByIdAsync(Guid id);
        Task AlterPostAsync(CartoonCategoryPostDto cartoonCategory);
        Task<IEnumerable<CartoonCategoryPostDto>> GetAllCategoryAsync();
    }
}
