using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ProductRateconfigurstion : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(r => r.Description).HasMaxLength(250).IsRequired();
            builder.Property(r=> r.Rate).IsRequired();
            builder.HasOne(P=>P.Product).WithMany(Pr=>Pr.ProductRates).HasForeignKey(x => x.ProductId);
        }
    }
}
