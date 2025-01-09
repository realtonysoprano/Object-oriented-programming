using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Models
{
	public class Window   //модель окна
	{
		internal bool isFavourite;

		public int id { set; get; }

		public string name { set; get; }

		public string size { set; get; }

		public string longDesc { set; get; }

		public string img { set; get; }

		public int price { set; get; }

		public int categoryID { set; get; }

		public bool available { set; get; }

		public bool isFavorite { set; get; }

		public virtual Category Category { set; get; }
	}
}
