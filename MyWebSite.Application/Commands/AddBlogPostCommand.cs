using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record AddBlogPostCommand(string Title, string SubTitle, ImageDto Thumb, string Description);
    
}
