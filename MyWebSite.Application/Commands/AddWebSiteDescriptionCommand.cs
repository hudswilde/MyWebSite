using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Application.Commands
{
    public record AddWebSiteDescriptionCommand(string Title, string SubTitle, string Description);
}
