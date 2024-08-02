using System;
using _9_Lesson_Online_Store_DataAccess.Repositories.Abstracts;
using _9_Lesson_Online_Store_DataAccess.Repositories.Concretes;
using _9_Lesson_Online_Store_Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace _9_Lesson_Online_Store_MVC.Controllers;

public class CategoryController :Controller
{
    private readonly ICategoryRepository? _categoryRepository;
    private readonly ITagRepository? _tagRepository;


    public CategoryController(ICategoryRepository categoryRepository,ITagRepository tagRepository)
    {
        _categoryRepository = categoryRepository;
        _tagRepository = tagRepository;
    }


    [HttpGet]
    public IActionResult AddCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddCategory(Category category)
    {
        //if (category == null)
        //{
        //    return BadRequest("Invalid category data");
        //}
        await  _categoryRepository?.AddAsync(category);
        return View(); ;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategory()
    {
        var categories =await _categoryRepository?.GetAllAsync();
        return View(categories);
    }

    [HttpGet]
    public async Task<IActionResult> AddTag(int id)
    {
        var category = await _categoryRepository.GetByIdAsync(id);
        ViewBag.Tags = await _tagRepository.GetAllAsync();
        return View(category);
    }

    [HttpPost]
    public async Task<IActionResult> AddTag(int id,int[] tags)
    {
        var category = await _categoryRepository.GetByIdWithTags(id);
        foreach(var tagId in tags)
        {
            var tag = await _tagRepository.GetByIdAsync(tagId);
            category.Tags.Add(tag);
        }
        //await _categoryRepository.SaveChanges();

        return RedirectToAction("AddTag");
    }
}

