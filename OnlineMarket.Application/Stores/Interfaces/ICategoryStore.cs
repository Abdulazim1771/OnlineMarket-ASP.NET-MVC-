using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.ViewModels.Category;

namespace OnlineMarket.Application.Stores.Interfaces;

public interface ICategoryStore
{
    List<CategoryViewModel> GetAll(GetCategoriesRequest request);
    CategoryViewModel GetById(CategoryRequest request);
    CategoryViewModel Create(CreateCategoryRequest request);
}
