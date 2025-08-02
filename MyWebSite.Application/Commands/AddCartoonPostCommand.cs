using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record AddCartoonPostCommand(string Title, string SubTitle, ImageDto Thumb, string Description);
    
}
