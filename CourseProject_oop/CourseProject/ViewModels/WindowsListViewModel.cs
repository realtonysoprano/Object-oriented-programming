using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.ViewModels
{
	public class WindowsListViewModel
	{
		// введение функций, возвращающих все окна и текущую категорию с её описанием
		public IEnumerable<Window> allWindows { get; set; }

		public string currCategory { get; set; }

		public string currDesc { get; set; }

	}
}
