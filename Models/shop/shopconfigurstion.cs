using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class shopconfigurstion : IEntityTypeConfiguration<Shop>
    {
        void IEntityTypeConfiguration<Shop>.Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop");
            builder.HasKey(x => x.Id);
            builder.HasMany(s => s.Products).WithOne(p => p.Shop);
        }
    }
}
