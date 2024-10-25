using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.ViewModels.Category;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.Mappings;

public static class CategoryMappings
{
    public static Category ToEntity(this CreateCategoryRequest request)
    {
        return new Category
        {
            Name = request.Name,
            Description = request.Description
        };
    }

    public static Category ToEntity(this UpdateCategoryRequest request)
    {
        return new Category
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
        };
    }

    public static CategoryViewModel ToViewModel(this Category category)
    {
        return new CategoryViewModel
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
        };
    }
}
