﻿using System;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<Category> GetByIdWithTags(long id);
}
