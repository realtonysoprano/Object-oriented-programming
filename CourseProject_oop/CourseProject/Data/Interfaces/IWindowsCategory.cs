using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Interfaces
{
	public interface IWindowsCategory   //интерфейс категорий
	{
		IEnumerable<Category> AllCategories{ get; }
	}
}
