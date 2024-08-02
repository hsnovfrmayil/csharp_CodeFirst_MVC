using System;
using _9_Lesson_Online_Store_DataAccess.Contexts;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Concretes;

public class TagRepository : GenericRepository<Tag>, ITagRepository
{
    public TagRepository(AppDbContext context) : base(context)
    {
    }
}

