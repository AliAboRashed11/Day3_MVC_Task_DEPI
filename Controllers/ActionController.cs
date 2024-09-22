using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
	public class ActionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult run() {
			
			
			return View("Tast");
		}
		
	}
}
