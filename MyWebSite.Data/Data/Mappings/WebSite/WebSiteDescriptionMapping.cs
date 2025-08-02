using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteDescriptionMapping : EntityBaseMapping<WebSiteDescription>
    {
        public override void Configure(EntityTypeBuilder<WebSiteDescription> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteDescription");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.SubTitle)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
