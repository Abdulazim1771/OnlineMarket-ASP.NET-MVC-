using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.Requests.Product;
using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket.Domain.Entities;
using OnlineMarket_ASP.NET_.Models;
using System.Diagnostics;

namespace OnlineMarket_ASP.NET_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryStore _categoryStore;
        private readonly IProductStore _productStore;

        public HomeController(ILogger<HomeController> logger, 
            ICategoryStore categoryStore, IProductStore productStore)
        {
            _categoryStore = categoryStore;
            _logger = logger;
            _productStore = productStore;   
        }

        public IActionResult Index()
        {
            var categories = _categoryStore.GetAll(new GetCategoriesRequest(null));
            ViewBag.Categories = categories;

            //var products = _productStore.GetAll(request);

            return View(null);
        }
        public IActionResult FilterByCategory(int? categoryId)
        {
            var products = new List<Product>();

            return View("Index", products);
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
