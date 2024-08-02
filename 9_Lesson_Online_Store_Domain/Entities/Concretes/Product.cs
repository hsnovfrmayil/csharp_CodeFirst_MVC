using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;

namespace _9_Lesson_Online_Store_Domain.Entities.Concretes;

public class Product :Entity
{
	public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public double? Price { get; set; }


    public int CategoryId { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<Tag> Tags { get; set; }
}

