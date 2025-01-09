using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Interfaces
{
	public interface IAllWindows    //интерфейс окон
	{
		IEnumerable<Window> Windows { get;  }
		IEnumerable<Window> getFavWindows { get; }
		Window getObjectWindow(int windowid);
	}
}
