using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteSocialMediaMapping : EntityBaseMapping<WebSiteSocialMedia>
    {
        public override void Configure(EntityTypeBuilder<WebSiteSocialMedia> builder)
        {
            base.Configure(builder);
            throw new NotImplementedException();
        }
    }
}
