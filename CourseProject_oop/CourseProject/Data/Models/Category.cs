using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Models
{
	public class Category     //модель категории окон
	{
		public int id { set; get; }

		public string categoryName { set; get; }

		public string desc { set; get; }

		public List<Window> Windows { set; get; }
	}
}
