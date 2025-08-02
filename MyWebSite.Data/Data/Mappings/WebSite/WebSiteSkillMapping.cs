using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteSkillMapping : EntityBaseMapping<WebSiteSkill>
    {
        public override void Configure(EntityTypeBuilder<WebSiteSkill> builder)
        {
            base.Configure(builder);
            builder.ToTable("WebSiteSkills");

            
            builder.Property(x => x.Percent)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
