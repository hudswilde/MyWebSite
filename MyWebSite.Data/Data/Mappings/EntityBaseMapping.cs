using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Infrastructure.Data.Mappings
{
    public abstract class EntityBaseMapping<T>() : IEntityTypeConfiguration<T> where T : BaseEntities 
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property<bool>("IsActive").IsRequired();
            builder.Property<DateTime>("CreatedDate").IsRequired();
            builder.Property<DateTime>("AlteredDate");
        }
    }
}
