using CourseProject.Data.Interfaces;
using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Mocks
{
	public class MockCategory : IWindowsCategory  //реализация интерфейса категорий
	{
		public IEnumerable<Category> AllCategories
		{
			get                                  //указываем категории, которые буду возвращаться при вызове ф-ции
			{
				return new List<Category>
				{
					new Category { categoryName = "Пластиковые окна", desc = "Пластиковые окна отличные конструкции, обеспечивающие качественную звукоизоляцию и предотвращающие потерю тепла."},
					new Category { categoryName = "Деревянные окна", desc = "Красота и надежность от природы по выгодной цене"},
					new Category { categoryName = "Алюминиевые окна", desc = "Алюминиевые окна – это легкая и надежная конструкция, в основе которой лежит изготовленный из алюминия профиль с установленным в него стеклопакетом."},
				};
			}
		}
	}
}
