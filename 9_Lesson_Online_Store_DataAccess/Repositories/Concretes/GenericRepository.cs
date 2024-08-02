using System;
using _9_Lesson_Online_Store_DataAccess.Contexts;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : Entity, new()
{
    protected readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity =await _context.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}

