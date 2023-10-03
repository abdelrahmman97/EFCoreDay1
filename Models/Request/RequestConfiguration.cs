

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {


        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable("Request");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.Details).IsRequired().HasMaxLength(500);
            builder.Property(i => i.ExpectSalary).IsRequired();
            builder.Property(i => i.State).IsRequired();
            builder.Property(i => i.StartDate).IsRequired();
            builder.Property(i => i.EndDate).IsRequired();
            builder.Property(i => i.RateValue).IsRequired();
            builder.Property(i => i.RateMassage).IsRequired().HasMaxLength(500);

            //CLIENTID
        }
    }
}
