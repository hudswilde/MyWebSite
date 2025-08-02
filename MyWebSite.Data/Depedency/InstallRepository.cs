using Microsoft.Extensions.DependencyInjection;
using MyWebSite.Domain.Interface.Repositories;
using MyWebSite.Domain.Interface.Repositories.Admin;
using MyWebSite.Domain.Interface.Repositories.Blog;
using MyWebSite.Domain.Interface.Repositories.WebSite;
using MyWebSite.Infrastructure.Data.Repositories;
using MyWebSite.Infrastructure.Data.Repositories.Blog;
using MyWebSite.Infrastructure.Data.Repositories.Cartoon;
using MyWebSite.Infrastructure.Data.Repositories.WebSite;
using MyWebSite.Infrastructure.Repositories.Data.Cartoon;

namespace MyWebSite.Infrastructure.Depedency
{
    public static class Repository
    {
        public static IServiceCollection InstallRepository(this IServiceCollection service) {
            service.AddScoped<IUserRepositorie, UserRepositorie>();
            service.AddScoped<IBlogCategoryPostRepositorie, BlogCategoryPostRepositorie>();
            service.AddScoped<IBlogPostRepositorie, BlogPostRepositorie>();
            service.AddScoped<ICartoonCategoryPostRepositorie, CartoonCategoryPostRepositorie>();
            service.AddScoped<ICartoonPostRepositorie, CartoonPostRepositorie>();
            service.AddScoped<IWebSiteDescriptionRepositorie, WebSiteDescriptionRepositorie>();
            service.AddScoped<IWebSiteGeralRepositorie, WebSiteGeralRepositorie>();
            service.AddScoped<IWebSiteknowledgesRepositorie, WebSiteknowledgesRepositorie>();
            service.AddScoped<IWebSiteSkillDescriptionRepositorie, WebSiteSkillDescriptionRepositorie>();
            service.AddScoped<IWebSiteSkillRepositorie, WebSiteSkillRepositorie>();
            service.AddScoped<IWebSiteSocialMediaRepositorie, WebSiteSocialMediaRepositorie>();
            service.AddScoped<IWebSiteTestemonialRepositorie, WebSiteTestemonialRepositorie>();
            return service;
        }
    }
}
