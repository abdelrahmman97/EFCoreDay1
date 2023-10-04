using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ServiceRateConfiguration : IEntityTypeConfiguration<ServiceRate>
    {
        public void Configure(EntityTypeBuilder<ServiceRate> builder)
        {
            builder.ToTable("ServiceRate", "Service");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Message).HasMaxLength(500).IsRequired();
            builder.Property(r => r.WorkQuality).IsRequired();
            builder.Property(r => r.NominateToOthers).IsRequired();
            builder.Property(r => r.RespectDeliveryTime).IsRequired();
            builder.HasOne(s => s.Service).WithMany(sr => sr.ServiceRates).HasForeignKey(x => x.ServiceID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
