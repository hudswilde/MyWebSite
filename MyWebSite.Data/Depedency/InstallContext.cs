using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyWebSite.Infrastructure.Data.Context;

namespace MyWebSite.Infrastructure.Depedency
{
    public static class InstallContext
    {
        public static IServiceCollection InstallApplicationContext(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<MyWebSiteContext>(option => option.UseNpgsql(connectionString));
            return service;
        }
    }
}
