using Day3.Middelware;
using Day3.Middelware3;

namespace Day3
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}

			
			app.UseStaticFiles();

			

			app.UseAuthorization();


			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
			app.UseMyMiddleware1();

			app.UseMyMiddleware2();

			app.UseMyMiddleware3();
			app.Run();
		}
	}
}