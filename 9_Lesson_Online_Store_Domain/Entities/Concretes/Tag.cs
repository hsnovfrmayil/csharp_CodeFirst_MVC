using System;
using _9_Lesson_Online_Store_Domain.Entities.Abstracts;

namespace _9_Lesson_Online_Store_Domain.Entities.Concretes;

public class Tag :Entity
{
    public string? Name { get; set; }


    public virtual ICollection<Category> Categories { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

