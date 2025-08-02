using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Context;

namespace MyWebSite.Infrastructure.Data.Repositories.WebSite
{
    public class WebSiteSkillDescriptionRepositorie : BaseRepositories<WebSiteSkillDescription>, IWebSiteSkillDescriptionRepositorie
    {
        public WebSiteSkillDescriptionRepositorie(MyWebSiteContext context) : base(context) { }
    }
}
