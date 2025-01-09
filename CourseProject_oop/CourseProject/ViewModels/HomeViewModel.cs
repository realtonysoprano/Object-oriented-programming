using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.ViewModels
{
	//Введение функций, возвращающих все окна, у которых isFavorite==true
	public class HomeViewModel
	{
		public IEnumerable<Window> favWindows { get; set; }
	}
}
