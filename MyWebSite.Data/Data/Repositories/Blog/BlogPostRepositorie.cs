using MyWebSite.Domain.Entities.Blog;
using MyWebSite.Domain.Interface.Repositories.Blog;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Data.Repositories.Blog
{
    public class BlogPostRepositorie : BaseRepositories<BlogPost>, IBlogPostRepositorie
    {
        public BlogPostRepositorie(MyWebSiteContext context) : base(context)
        {
        }
    }
}
