using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {


       
       public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Message");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.Content).IsRequired().HasMaxLength(500);
            builder.Property(i => i.Date).IsRequired();

            builder.HasOne(i => i.User).WithMany(i => i.Messages).HasForeignKey(i => i.SenderId).IsRequired();
            builder.HasOne(i => i.Chat).WithMany(i => i.Messages).HasForeignKey(i => i.ChatId).IsRequired();

        }
    }
}
