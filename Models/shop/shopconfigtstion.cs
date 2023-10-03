using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class shopconfigtstion : IEntityTypeConfiguration<shop>
    {
        public void Configure(EntityTypeBuilder<shop> builder)
        {
            builder.HasKey(s => s.ShopID);
            builder.Property(s => s.ShopName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(250).IsRequired();
            builder.Property(s => s.Owner).IsRequired();
        }
    }
}
