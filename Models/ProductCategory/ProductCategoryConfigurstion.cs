using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFCoreDay1.Models
{
    public class ProductCategoryConfigurstion : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory", "Product");
            builder.HasKey(x => x.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.Catagory).IsRequired().HasMaxLength(500);
        }
    }
}
