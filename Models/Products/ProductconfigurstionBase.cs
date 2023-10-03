﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDay1.Models
{
    public class ProductconfigurstionBase : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.HasOne(p => p.Category).WithMany(c => c.Prouducts).HasForeignKey(p => p.CategoryID);
            builder.HasOne(p => p.Shop).WithMany(s => s.Products).HasForeignKey(p => p.ShopID);
        }
    }
}