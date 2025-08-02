using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record UpdateCartoonPostCommand(Guid Id, string Title, string SubTitle, ImageDto Thumb, string Description);
    
}
