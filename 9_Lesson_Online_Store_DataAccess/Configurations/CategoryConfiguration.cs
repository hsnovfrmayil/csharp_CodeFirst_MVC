using System;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _9_Lesson_Online_Store_DataAccess.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(u => u.CategoryId);

        builder.HasMany(c => c.Tags)
            .WithMany(p => p.Categories);
    }
}

