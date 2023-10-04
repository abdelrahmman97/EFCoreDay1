using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class ShopConfigtstion : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop", "Shop");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.Name).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(250).IsRequired();
            builder.HasOne(s => s.Owner).WithOne(i => i.Shop).HasForeignKey<Shop>(i=>i.ID);

        }
    }
}
