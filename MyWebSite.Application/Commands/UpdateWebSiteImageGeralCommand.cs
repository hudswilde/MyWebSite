using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Commands
{
    public record UpdateWebSiteImageGeralCommand(Guid Id, ImageDto Image);
}
