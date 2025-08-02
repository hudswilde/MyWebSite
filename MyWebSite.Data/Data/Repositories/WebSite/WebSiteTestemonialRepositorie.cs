using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Context;

namespace MyWebSite.Infrastructure.Data.Repositories.WebSite
{
    public class WebSiteTestemonialRepositorie : BaseRepositories<WebSiteTestemonial>, IWebSiteTestemonialRepositorie
    {
        public WebSiteTestemonialRepositorie(MyWebSiteContext context) : base(context)
        {
        }
    }
}
