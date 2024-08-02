using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;

namespace _9_Lesson_Online_Store_Domain.Entities.Concretes;

public class Category : Entity
{
	public string? Name { get; set; }


	public virtual ICollection<Tag> Tags { get; set; }

    public virtual ICollection<Product> Products { get; set; }

}

