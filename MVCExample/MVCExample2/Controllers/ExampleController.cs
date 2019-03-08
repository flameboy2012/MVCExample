using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new FormViewModel
            {
                Name = "World"
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            var viewModel = new FormViewModel
            {
                Name = name
            };

            return View(viewModel);
        }
    }


}