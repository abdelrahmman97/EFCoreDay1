using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreDay1.Models
{
    public class ServiceCategoryConfiguration : IEntityTypeConfiguration<ServicCategory>
    {
        public void Configure(EntityTypeBuilder<ServicCategory> builder)
        {
            builder.HasKey(x => x.Id);  

            builder.Property(x => x.Category)
                .HasColumnType("varchar(30)")
                .IsRequired();
            //builder.HasMany(e => e.Services)
            //     .WithOne(e => e.Category)
            //     .HasForeignKey(e => e.CategoryId)
            //     .IsRequired();
        }
    }
}
