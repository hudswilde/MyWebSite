using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record UpdateImageCommand(Guid Id, ImageDto Image);
}
