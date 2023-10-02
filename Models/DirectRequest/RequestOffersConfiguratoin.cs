using EFCoreDay1.Models;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class RequestOffersConfiguratoin : IEntityTypeConfiguration<RequestOffers>
    {
        public void Configure(EntityTypeBuilder<RequestOffers> builder)
        {
            builder.ToTable("RequestOffer");
            builder.HasKey(i => i.ID);
            builder.Property(i=>i.ID).ValueGeneratedOnAdd();
            builder.Property(s=>s.state).IsRequired().HasMaxLength(8);
            builder.Property(d=>d.Direct).IsRequired().HasMaxLength(8);
            builder.HasOne(i => i.Request)
            .WithOne(i => i.DirectRequest)
            .HasForeignKey("ID")
            .IsRequired();
            builder.HasOne(i => i.User).WithMany(p => p.requestOffers).HasForeignKey(k => k.ProviderID);

        }
    }
}
