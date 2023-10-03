using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(D => D.ID);
            builder.Property(n => n.Title).IsRequired().HasMaxLength(250);
            builder.Property(D => D.Discription).IsRequired().HasMaxLength(250);
            builder.Property(r => r.Rate).IsRequired().HasColumnType("float");
            builder.Property(E => E.ExpectedSalary).IsRequired().HasColumnType("float");
            builder.HasOne(e => e.ServiceCategory).WithMany(e => e.Services).HasForeignKey(e => e.CategoryID).IsRequired();
            builder.HasOne(e => e.User).WithMany(e => e.Services).HasForeignKey(e => e.ProviderID).IsRequired();
        }
    }
}
