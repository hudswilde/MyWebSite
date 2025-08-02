using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.Blog;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class BlogCategoryPostMapping : EntityBaseMapping<BlogCategoryPost>
    {
        public override void Configure(EntityTypeBuilder<BlogCategoryPost> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteDescription");

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();
           
        }
    }
}
