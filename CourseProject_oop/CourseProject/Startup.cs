using CourseProject.Data.Interfaces;
using CourseProject.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CourseProject
{
	public class Startup
	{

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<IAllWindows, MockWindows>(); //позволяет связать интерфейс с его реализацией
			services.AddTransient<IWindowsCategory, MockCategory>();
			services.AddMvc();
		}


		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseStatusCodePages();
			app.UseStaticFiles(); // Подключение Microsoft.AspNetCore.StaticFiles 
			app.UseMvcWithDefaultRoute(); // Осуществляет переадресацию на главную страницу

		}
	}
}
