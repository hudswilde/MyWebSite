using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Data.Repositories.WebSite
{
    public class WebSiteSkillRepositorie : BaseRepositories<WebSiteSkill>, IWebSiteSkillRepositorie
    {
        public WebSiteSkillRepositorie(MyWebSiteContext context) : base(context) { }
    }
}
