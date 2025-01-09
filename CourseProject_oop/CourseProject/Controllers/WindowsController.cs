using CourseProject.Data.Interfaces;
using CourseProject.Data.Models;
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
	public class WindowsController : Controller
	{
		private readonly IAllWindows _allWindows;
		private readonly IWindowsCategory _allCategories;

		public WindowsController(IAllWindows iAllWindows, IWindowsCategory iWindowsCat)
		{
			_allWindows = iAllWindows;
			_allCategories = iWindowsCat;
		}

		[Route("Windows/List")]    //Указание ссылок, которые будет использовать представление
		[Route("Windows/List/{category}")]
		public ViewResult List(string category)
		{
			string _category = category;
			IEnumerable<Window> windows = null;
			string currCategory ="";
			string currDesc = "";
			if (string.IsNullOrEmpty(category))
			{
				windows = _allWindows.Windows.OrderBy(i => i.id); //Запись в переменную всех элементов если category не указана

			}
			else
			//Запись в перменную всех элементов соответствующих укзаннной category
			{
				if (string.Equals("plastic", category, StringComparison.OrdinalIgnoreCase))
				{
					windows = _allWindows.Windows.Where(i => i.Category.categoryName.Equals("Пластиковые окна")).OrderBy(i => i.id);
					currCategory = "Пластиковые окна";
					currDesc = "Пластиковые окна отличные конструкции, обеспечивающие качественную звукоизоляцию и предотвращающие потерю тепла.";
				}
				else if (string.Equals("Wood", category, StringComparison.OrdinalIgnoreCase))
				{
					windows = _allWindows.Windows.Where(i => i.Category.categoryName.Equals("Деревянные окна")).OrderBy(i => i.id);
					currCategory = "Деревянные окна";
					currDesc = "Красота и надежность от природы по выгодной цене";
				}
				else if (string.Equals("aluminum", category, StringComparison.OrdinalIgnoreCase))
				{
					windows = _allWindows.Windows.Where(i => i.Category.categoryName.Equals("Алюминиевые окна")).OrderBy(i => i.id);
					currCategory = "Алюминиевые окна";
					currDesc = "Алюминиевые окна – это легкая и надежная конструкция, в основе которой лежит изготовленный из алюминия профиль с установленным в него стеклопакетом.";
				}
			}


			var windowObj = new WindowsListViewModel
			{
				allWindows = windows,
				currCategory = currCategory,
				currDesc = currDesc
			};
			ViewBag.Title = "Страница с окнами";

			return View(windowObj); //Передача полученного списка окон в html шаблон

		}
	}
}
