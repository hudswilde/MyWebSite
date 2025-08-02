using Microsoft.EntityFrameworkCore;
using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;
using System.Runtime.CompilerServices;

namespace MyWebSite.Infrastructure.Data.Repositories.WebSite
{
    public class WebSiteDescriptionRepositorie : BaseRepositories<WebSiteDescription>, IWebSiteDescriptionRepositorie
    {
        
        public WebSiteDescriptionRepositorie(MyWebSiteContext context) : base(context) { }

        public async Task<IEnumerable<WebSiteDescription>> GetAllActiveAsync()
        {
            return await  _dbSet.Where(x => x.IsActive == true).ToListAsync();
        }
    }
}
