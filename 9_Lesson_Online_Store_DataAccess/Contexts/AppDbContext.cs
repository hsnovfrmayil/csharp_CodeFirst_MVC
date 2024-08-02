using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace _9_Lesson_Online_Store_DataAccess.Contexts;

public class AppDbContext :DbContext
{
    public AppDbContext() { }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Məlumat bazası provayderinizi təyin edin
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ECompanyDb;User ID=SA;Password=reallyStrongPwd123;TrustServerCertificate=True");
            // Yoxsa başqa bir provayder istifadə edə bilərsiniz, məsələn:
            // optionsBuilder.UseSqlite("YourConnectionStringHere");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }
}

