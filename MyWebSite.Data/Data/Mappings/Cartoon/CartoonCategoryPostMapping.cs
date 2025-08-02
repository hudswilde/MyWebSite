using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.Cartoon;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class CartoonCategoryPostMapping : EntityBaseMapping<CartoonCategoryPost>
    {
        public override void Configure(EntityTypeBuilder<CartoonCategoryPost> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteDescription");

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
