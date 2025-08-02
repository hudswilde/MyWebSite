using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteGeralMapping : EntityBaseMapping<WebSiteGeral>
    {
        public override void Configure(EntityTypeBuilder<WebSiteGeral> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteGeral");

            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Email)
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
