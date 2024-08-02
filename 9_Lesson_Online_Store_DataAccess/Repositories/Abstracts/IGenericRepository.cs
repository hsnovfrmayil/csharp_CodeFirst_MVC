using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;

public interface IGenericRepository<T> where T: Entity, new()
{
    Task<List<T>> GetAllAsync();

    Task<T> GetByIdAsync(int id);

    Task AddAsync(T entity);

    Task Update(T entity);

    Task DeleteAsync(int id);

    Task SaveChanges();

}

