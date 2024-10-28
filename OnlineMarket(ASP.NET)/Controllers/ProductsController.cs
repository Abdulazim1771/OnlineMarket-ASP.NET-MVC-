using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.Requests.Product;
using OnlineMarket.Application.Stores.Interfaces;

namespace OnlineMarket_ASP.NET_.Controllers;

public class ProductsController : Controller
{
    public const int MaxFileSize = 2 * 1024 * 1024;
    public const int MinFileSize = 1024;

    private static readonly List<string> _allowedFileTypes =
    [
        "png", "jpeg", "gif", "pdf"
    ];

    private readonly ICategoryStore _categoryStore;
    private readonly IProductStore _productStore;

    public ProductsController(ICategoryStore categoryStore, IProductStore store)
    {
        _productStore = store ?? throw new ArgumentNullException(nameof(store)); ;
        _categoryStore = categoryStore ?? throw new ArgumentNullException(nameof(store)); ;
    }

    public IActionResult Index([FromQuery] GetProductsRequest request)
    {
        

        return View();
    }

    public IActionResult Create([FromForm] CreateProductRequest request, [FromForm] List<IFormFile> attachments)
    {
        if(!ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }

        foreach (var attachment in attachments)
        {
            if (!TryValidateFile(ModelState, attachment))
            {
                PopulateViewBag(request.CategoryId);

                return View(request);
            }
        }

        var createdProduct = _productStore.Create(request, attachments);

        return RedirectToAction(nameof(HomeController.Index), new { id = createdProduct.Id });
    }

    private static bool TryValidateFile(ModelStateDictionary modelState, IFormFile? formFile)
    {
        if (formFile is null)
        {
            return true;
        }

        if (formFile.Length < MinFileSize)
        {
            modelState.AddModelError(string.Empty, "Image file is too small.");

            return false;
        }

        if (formFile.Length > MaxFileSize)
        {
            modelState.AddModelError(string.Empty, "Image file is too big.");

            return false;
        }

        if (!_allowedFileTypes.Exists(type => formFile.ContentType.Contains(type)))
        {
            modelState.AddModelError(string.Empty, "Invalid image format");

            return false;
        }

        return true;
    }

    private void PopulateViewBag(int? categoryId = null)
    {
        var categories = _categoryStore.GetAll(new GetCategoriesRequest(null));

        var defaultCategory = categoryId.HasValue
            ? categories.First(x => x.Id == categoryId.Value)
            : categories.FirstOrDefault();

        ViewBag.Categories = categories;
        ViewBag.DefaultCategory = defaultCategory;
    }
}
