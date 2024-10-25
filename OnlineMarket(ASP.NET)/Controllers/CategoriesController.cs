using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket.Application.ViewModels.Category;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket_ASP.NET_.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryStore _store;

    public CategoriesController(ICategoryStore store)
    {
        _store = store;
    }


    public IActionResult Index([FromQuery] GetCategoriesRequest request)
    {
        var categories = _store.GetAll(request);

        return View(categories);
    }

    public ActionResult Details([FromRoute] CategoryRequest request)
    {
        var category = _store.GetById(request);

        return View(category);
    }

    // GET: CategoryController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: CategoryController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: CategoryController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: CategoryController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: CategoryController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: CategoryController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    /// <summary>
    /// Filters categories
    /// </summary>
    /// <param name="search"></param>
    /// <returns>List of filtered categories</returns>
    [Route("getCategories")]
    public ActionResult<CategoryViewModel> GetCategories([FromQuery] GetCategoriesRequest request)
    {
        var categories = _store.GetAll(request);

        return Ok(categories);
    }
}
