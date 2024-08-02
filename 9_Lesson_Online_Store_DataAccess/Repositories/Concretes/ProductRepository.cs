using System;
using _9_Lesson_Online_Store_DataAccess.Contexts;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;

namespace _9_Lesson_Online_Store_DataAccess.Repositories.Concretes;

public class ProductRepository :GenericRepository<Product>, IProductRepository
{

	public ProductRepository(AppDbContext context): base(context)
	{

	}
}

