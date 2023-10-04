using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        

       public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("Chat");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();

            //builder.Property(i => i.FirstUserId).IsRequired();
            //builder.Property(i => i.SecondUserId).IsRequired();

            builder.HasMany(c =>c.Users).WithMany(c => c.Chats).

         


        }
    }
}
