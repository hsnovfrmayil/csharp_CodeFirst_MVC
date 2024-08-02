using System;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace _9_Lesson_Online_Store_MVC.Controllers;

public class TagController :Controller
{
    private readonly ITagRepository _tagRepository;

    public TagController(ITagRepository tagRepository) {
        _tagRepository = tagRepository;
    }

    [HttpGet]
    public IActionResult AddTag()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult>  AddTag(Tag tag)
    {
        await _tagRepository.AddAsync(tag);
        return View();
    }


   
}

