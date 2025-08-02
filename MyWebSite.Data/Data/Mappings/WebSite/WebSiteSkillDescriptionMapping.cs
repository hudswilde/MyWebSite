using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Mappings.WebSite
{
    public class WebSiteSkillDescriptionMapping : EntityBaseMapping<WebSiteSkillDescription>
    {
        public override void Configure(EntityTypeBuilder<WebSiteSkillDescription> builder)
        {
            throw new NotImplementedException();
        }
    }
}
