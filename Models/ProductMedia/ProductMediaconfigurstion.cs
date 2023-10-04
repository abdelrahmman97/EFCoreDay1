using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ProductMediaConfiguration : IEntityTypeConfiguration<ProductMedia>
    {
        public void Configure(EntityTypeBuilder<ProductMedia> builder)
        {
            builder.ToTable("ProductMedia", "Product");
            builder.HasKey(m => m.ID);
            builder.Property(m => m.MeadiUrl).HasMaxLength(250).IsRequired();
            builder.HasOne(m => m.Product).WithMany(m => m.ProductMedias).HasForeignKey(m => m.ProductID);
        }
    }
}
