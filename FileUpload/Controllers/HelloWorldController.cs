using FileUpload.Models;
using Microsoft.AspNetCore.Mvc;

namespace FileUpload.Controllers
{
	public class HelloWorldController : Controller
	{
		private static List<DogViewModel> doggos = new List<DogViewModel>();
		public IActionResult Index()
		{
			return View(doggos);
		}

		public IActionResult Create()
		{
			var createNewDog = new DogViewModel();
			return View(createNewDog);
		}

		public IActionResult CreateDog(DogViewModel model)
		{
			//return View("Index");
			doggos.Add(model);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Greeting()
		{
			DogViewModel doggos = new DogViewModel()
			{
				Name = "Petter",
				Age = 20,
			};
			return View(doggos);
		}
	}
}
