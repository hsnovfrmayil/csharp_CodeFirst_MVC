using System;
using Microsoft.AspNetCore.Mvc;

namespace _9_Lesson_Online_Store_MVC.ViewComponents;

public class AdminDashboardNewOrderViewComponent :ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}

