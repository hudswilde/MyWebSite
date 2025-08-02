using MyWebSite.Domain.Entities.Cartoon;
using MyWebSite.Domain.Interface.Repositories.Blog;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Repositories.Data.Cartoon
{
    public class CartoonCategoryPostRepositorie : BaseRepositories<CartoonCategoryPost>, ICartoonCategoryPostRepositorie
    {
        public CartoonCategoryPostRepositorie(MyWebSiteContext context) : base(context)
        {
        }
    }
}
