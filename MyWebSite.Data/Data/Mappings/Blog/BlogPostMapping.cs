using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities;
using MyWebSite.Domain.Entities.Blog;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class BlogPostMapping : EntityBaseMapping<BlogPost>
    {
        public override void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteDescription");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("text");

            builder.Property(x => x.SubTitle)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnType("text");

            builder.Property(x => x.Description)
                .HasColumnType("text")
                .IsRequired();

            builder.HasMany(x => x.ListCategoryPost)
              .WithMany(x => x.ListBlogPost)
              .UsingEntity(x => x.ToTable("BlogPostBlogCategory"));
        }
    }
}
