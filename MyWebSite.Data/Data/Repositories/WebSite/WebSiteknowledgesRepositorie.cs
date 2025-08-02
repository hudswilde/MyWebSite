using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Data.Repositories.WebSite
{
    public class WebSiteknowledgesRepositorie : BaseRepositories<WebSiteknowledge>, IWebSiteknowledgesRepositorie
    {
        public WebSiteknowledgesRepositorie(MyWebSiteContext context) : base(context) { }
    }
}
