using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    internal class MessageMediaConfiguration : IEntityTypeConfiguration<MessageMedia>
    {
        public void Configure(EntityTypeBuilder<MessageMedia> builder)
        {
            builder.ToTable("MessageMedia", "Chat");
            builder.HasOne(m => m.Message).WithMany(M=>M.MessageMedias).HasForeignKey(m=>m.MessageID);
        }
    }
}
