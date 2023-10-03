using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFCoreDay1.Models
{
    public class  Categoryconfigurstion : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {     
            builder.ToTable("Category");
            builder.HasKey(x => x.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i=>i.Catagory).IsRequired().HasMaxLength(500);
           


            

            //builder
            //    .HasKey(i => i.ID);
            //builder.Property
            //    (i => i.ID).ValueGeneratedOnAdd();

            //builder.Property
            //   (i => i.Title).IsRequired().HasMaxLength(500);

        }
    }
}
