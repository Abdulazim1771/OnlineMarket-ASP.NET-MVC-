using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket_ASP.NET_.Models;
using System.Diagnostics;

namespace OnlineMarket_ASP.NET_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryStore _categoryStore;

        public HomeController(ILogger<HomeController> logger, ICategoryStore categoryStore)
        {
            _categoryStore = categoryStore;
            _logger = logger;
        }

        public IActionResult Index([FromQuery] GetCategoriesRequest getCategoryRequest)
        {
            var categories = _categoryStore.GetAll(getCategoryRequest);
            ViewBag.Categories = categories;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
