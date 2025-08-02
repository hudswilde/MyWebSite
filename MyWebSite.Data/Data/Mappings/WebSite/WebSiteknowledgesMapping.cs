using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteknowledgesMapping : EntityBaseMapping<WebSiteknowledge>
    {
        public override void Configure(EntityTypeBuilder<WebSiteknowledge> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteKnowledges");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
