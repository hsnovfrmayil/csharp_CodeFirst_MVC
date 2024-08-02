using System;
using Microsoft.AspNetCore.Mvc;

namespace _9_Lesson_Online_Store_MVC.Controllers;

public class AdminController :Controller
{
	public IActionResult Dashboard()
	{
		return View();
	}

    public IActionResult Index()
    {
        return View();
    }
}

