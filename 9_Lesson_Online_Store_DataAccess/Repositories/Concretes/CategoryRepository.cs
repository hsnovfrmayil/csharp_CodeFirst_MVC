using System;
using _9_Lesson_Online_Store_DataAccess.Contexts;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Concretes;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Category> GetByIdWithTags(long id)
    {
        return await _context.Categories.Include(x => x.Tags).FirstOrDefaultAsync(x=>x.Id==id);
    }
}

