using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteTestemonialMapping : EntityBaseMapping<WebSiteTestemonial>
    {
        public override void Configure(EntityTypeBuilder<WebSiteTestemonial> builder)
        {
            base.Configure(builder);
            throw new NotImplementedException();
        }
    }
}
