using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class productRoleconfigurstion : IEntityTypeConfiguration<ProductRate>
    {
        void IEntityTypeConfiguration<ProductRate>.Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.HasOne(r => r.Product).WithMany(p => p.ProductRates).HasForeignKey(r => r.productId);
        }
    }
}
