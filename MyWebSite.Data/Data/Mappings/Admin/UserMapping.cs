using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities.Admin;

namespace MyWebSite.Infrastructure.Data.Mappings.Admin
{
    public class UserMapping : EntityBaseMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("User");
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
        }
    }
}
