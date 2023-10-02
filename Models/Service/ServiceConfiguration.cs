using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(D => D.Id);
            builder.Property(n => n.Title)
                .HasColumnType("varchar(20)")
                .HasMaxLength(250)
                .IsRequired()
                .HasDefaultValue("titl");
            builder.Property(D => D.Discription)
                .IsRequired()
                .HasColumnType("varchar(250)")
                .HasDefaultValue("Discription")
                ;
            builder.Property(r=>r.Rate)
                .IsRequired();
            builder.Property(E=>E.ExpectedSalary)
                .IsRequired()
                ;
            builder.HasOne(e => e.Category)
                .WithMany(e => e.Services)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();
            builder.HasOne(e => e.User)
               .WithMany(e => e.Services)
               .HasForeignKey(e => e.ProviderId)
               .IsRequired();



        }
    }
}
