﻿using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Error404()
		{
			return View();
		}
	}
}
