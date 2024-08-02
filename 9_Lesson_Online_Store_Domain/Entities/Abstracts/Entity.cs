using System;
namespace _9_Lesson_Online_Store_Domain.Entities.Abstracts;

public abstract class Entity
{
	public int Id { get; set; }

	public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}

