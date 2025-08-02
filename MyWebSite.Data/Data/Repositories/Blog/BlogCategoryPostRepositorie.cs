using MyWebSite.Domain.Entities.Blog;
using MyWebSite.Domain.Interface.Repositories.Blog;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Data.Repositories.Blog
{
    public class BlogCategoryPostRepositorie : BaseRepositories<BlogCategoryPost>, IBlogCategoryPostRepositorie
    {
        public BlogCategoryPostRepositorie(MyWebSiteContext context) : base(context)
        {
        }
    }
}
