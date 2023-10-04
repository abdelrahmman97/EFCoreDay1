
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFCoreDay1.Models
{
    public class ServiceCategoryConfiguration : IEntityTypeConfiguration<ServiceCategory>
    {
        public void Configure(EntityTypeBuilder<ServiceCategory> builder)
        {
            builder.ToTable("ServiceCategory", "Service");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        }
    }
}
