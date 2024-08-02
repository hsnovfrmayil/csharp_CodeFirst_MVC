using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _9_Lesson_Online_Store_DataAccess.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(u => u.Name)
            .HasMaxLength(50)
            .IsRequired();
    }
}

