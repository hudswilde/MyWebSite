using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record UpdateBlogpostCommand(Guid Id, string Title, string SubTitle, ImageDto Thumb, string Description);
    
}
