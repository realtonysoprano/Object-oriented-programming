using CourseProject.Data.Interfaces;
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
	public class HomeController : Controller
	{
		//Создание и ввод переменной, хранящей список всех окон, при помощи конструктора 
		private IAllWindows _windowRep;
	
		public HomeController(IAllWindows windowRep)
		{
			_windowRep = windowRep;
		}
		//Вызов html шаблона
		public ViewResult Index()
		{
			var homeWindows = new HomeViewModel //Ввод переменной, хранящей в себе те окна, у которых isFavourite == true;
			{
				favWindows = _windowRep.Windows.Where(p => p.isFavorite) //Отбор этих окон и запись в переменную
			};
			return View(homeWindows); //Передача нужных окон в html шаблон
		}
	}
}
