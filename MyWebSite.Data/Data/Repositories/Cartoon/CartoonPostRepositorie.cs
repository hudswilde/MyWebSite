using MyWebSite.Domain.Entities.Cartoon;
using MyWebSite.Domain.Interface.Repositories.Blog;
using MyWebSite.Infrastructure.Data.Context;
using MyWebSite.Infrastructure.Data.Repositories;

namespace MyWebSite.Infrastructure.Data.Repositories.Cartoon
{
    public class CartoonPostRepositorie : BaseRepositories<CartoonPost>, ICartoonPostRepositorie
    {
        public CartoonPostRepositorie(MyWebSiteContext context) : base(context)
        {
        }
    }
}
