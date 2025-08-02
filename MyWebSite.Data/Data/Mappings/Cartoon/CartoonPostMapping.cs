using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.Cartoon;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class CartoonPostMapping : EntityBaseMapping<CartoonPost>
    {
        public override void Configure(EntityTypeBuilder<CartoonPost> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteDescription");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("text");

            builder.Property(x => x.Cartoon)
                .HasMaxLength(200)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(x => x.SubTitle)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnType("text");

            builder.Property(x => x.Description)
                .HasColumnType("text");
        }
    }
}
