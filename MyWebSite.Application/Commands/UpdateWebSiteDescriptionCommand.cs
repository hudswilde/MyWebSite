using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Application.Commands
{
    public record UpdateWebSiteDescriptionCommand(Guid Id,string Title, string SubTitle, string Description);
}
