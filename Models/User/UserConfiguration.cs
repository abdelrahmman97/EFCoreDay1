

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "User");
            builder.HasKey(u => u.ID);
            builder.Property(u => u.ID).ValueGeneratedOnAdd();
            builder.Property(u => u.FName).IsRequired().HasMaxLength(128);
            builder.Property(u => u.LName).IsRequired().HasMaxLength(128);
            builder.Property(u => u.SSN).IsRequired().HasMaxLength(14);
            builder.Property(u => u.PhoneNo).IsRequired().HasMaxLength(11);
            builder.Property(u => u.Address).IsRequired().HasMaxLength(250);
            builder.Property(u => u.Username).IsRequired().HasMaxLength(250);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(250);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.ProfilePic).IsRequired();

        }
    }
}
