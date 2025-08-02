using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities;

namespace MyWebSite.Infrastructure.Data.Mappings
{
    public class ImageMapping : EntityBaseMapping<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);
            builder.ToTable("Image");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.Alias).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weigth).IsRequired();

            builder.HasOne(x => x.WebSiteGeral).WithMany(x => x.Images);
            builder.HasOne(x => x.BlogPost).WithMany(x => x.Images);
            builder.HasOne(x => x.WebSiteknowledge).WithMany(x => x.Images);
            builder.HasOne(x => x.CartoonPost).WithMany(x => x.Images);
            builder.HasOne(x => x.User).WithMany(x => x.Images);
            builder.HasOne(x => x.WebSiteSkillDescription).WithMany(x => x.Images);
            builder.HasOne(x => x.WebSiteSocialMedia).WithMany(x => x.Images);
            builder.HasOne(x => x.WebSiteTestemonial).WithMany(x => x.Images);
        }
    }
}
