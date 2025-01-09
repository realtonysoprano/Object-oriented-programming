using CourseProject.Data.Interfaces;
using CourseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Data.Mocks
{
	public class MockWindows : IAllWindows  //реализация интерфейса окон
	{
		private readonly IWindowsCategory _categoryWindows = new MockCategory();
		public IEnumerable<Window> Windows {
			get
			{
				return new List<Window>
				{
					// указываем характеристики окон
					new Window { name = "Двухстворчатое окно",
						         size = "1450х1415 мм",
						         longDesc = "Самый доступный вариант из древесины сосны. Такие окна хорошо сохраняют тепло и обеспечивают качественную шумозащиту. ",
								 img = "/img/1.jpg",
						         price = 38000,
						         isFavorite = true,
								 available = true,
								 Category = _categoryWindows.AllCategories.ElementAt(1)
					},
					new Window { name = "Балконный блок",
								 size = "1800x1500 мм",
								 longDesc = "Сделано из древесины лиственницы, для которой характерна максимальная устойчивость к воздействию влаги и механическим повреждениям.",
								 img = "/img/2.jpg",
								 price = 90000,
								 isFavorite = false,
								 available = true,
								 Category = _categoryWindows.AllCategories.ElementAt(1)
					},
					new Window { name = "Двухстворчатое окно",
								 size = "960x1040 мм",
								 longDesc = "Окно сделано из термопластических синтетических материалов. Отличный бюджетный вариант для однокомнатной квартиры",
								 img = "/img/3.jpg",
								 price = 7000,
								 isFavorite = true,
								 available = false,
								 Category = _categoryWindows.AllCategories.First()
					},
					new Window { name = "Трехстворчатое окно",
								 size = "1560x2160 мм",
								 longDesc = "Окно лакировано в белом цвете. Мультифункциональный стеклопакет в подарок.",
								 img = "/img/4.jpg",
								 price = 15000,
								 isFavorite = false,
								 available = false,
								 Category = _categoryWindows.AllCategories.First()
					},
					new Window { name = "Трехстворчатое окно",
								 size = " 1560x2160 мм",
								 longDesc = "Они эффектно смотрятся в интерьере и на фасаде, делают вид проема более солидным. Цветное покрытие в оттенках RAL-палитры не выгорает на солнце.",
								 img = "/img/5.jpg",
								 price =  18000,
								 isFavorite = true,
								 available = true,
								 Category = _categoryWindows.AllCategories.First()
					},
					new Window { name = "Одностворчатое окно",
								 size = "600х1415 мм",
								 longDesc = "Сделано из дуба. Среди всех пород дерева дуб является бесспорным лидером по показателю прочности, плотности и долговечности.",
								 img = "/img/6.jpg",
								 price = 35000,
								 isFavorite = false,
								 available = true,
								 Category = _categoryWindows.AllCategories.ElementAt(1)
					},
					new Window { name = "Раздвижное окно",
								 size = " 800x1700 мм",
								 longDesc = "Небольшой вес. Устанавливается на любые балконы без риска их деформации.",
								 img = "/img/7.jpg",
								 price =  5600,
								 isFavorite = true,
								 available = true,
								 Category = _categoryWindows.AllCategories.Last()
					},
					new Window { name = "Раздвижное из 3 створок",
								 size = "2400x1700 мм",
								 longDesc = "Защищаeт от проникновения в дом пыли, осадков, уличного шума. Раздвижные модели имеют увеличенный световой проем",
								 img = "/img/8.jpg",
								 price = 14920,
								 isFavorite = false,
								 available = true,
								 Category = _categoryWindows.AllCategories.Last()
					}
				};
			}
				}
		public IEnumerable<Window> getFavWindows { get; set; }

		public Window getObjectWindow(int windowid)
		{
			throw new NotImplementedException();
		}
	}
}
