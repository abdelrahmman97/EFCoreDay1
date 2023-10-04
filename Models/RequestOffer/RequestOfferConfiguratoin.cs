using EFCoreDay1.Models;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class RequestOfferConfiguratoin : IEntityTypeConfiguration<RequestOffer>
    {
        public void Configure(EntityTypeBuilder<RequestOffer> builder)
        {
            builder.ToTable("RequestOffer", "Service");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(s => s.State).IsRequired().HasMaxLength(15);
            builder.Property(d => d.IsDirect).IsRequired().HasColumnType("bit");

            builder.HasOne(i => i.Request).WithMany(i => i.RequestOffer).HasForeignKey(i => i.RequestID).IsRequired();
            builder.HasOne(i => i.User).WithMany(p => p.RequestOffer).HasForeignKey(k => k.ProviderID);

        }
    }
}
