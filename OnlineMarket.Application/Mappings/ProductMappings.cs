using OnlineMarket.Application.Requests.Product;
using OnlineMarket.Application.ViewModels.Product;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.Mappings;

public static class ProductMappings
{
    public static ProductViewModel ToViewModel(this Product product)
    {
        return new ProductViewModel
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            SKU = product.SKU,
            Price = product.Price,
            Category = product.Category.ToViewModel(),
            Quantity = product.Inventory?.Quantity ?? 0,
            Inventory = product.Inventory,
            CategoryName = product.Category.Name,
            Reviews = [],
            ProductRating = GetProductRating(product),
            Images = product.Images.Select(x => Convert.ToBase64String(x.Data)).ToList()
        };
    }

    public static Product ToEntity(this CreateProductRequest product)
    {
        return new Product
        {
            Name = product.Name,
            Description = product.Description,
            SKU = product.SKU,
            Price = product.Price,
            CategoryId = product.CategoryId,
            Category = null,
            Inventory = new Inventory
            {
                Quantity = product.Quantity,
                ProductId = product.ProductId,
                Product = null
            }
        };
    }

    public static Product ToEntity(this UpdateProductRequest request)
    {
        return new Product
        {
            Name = request.Name,
            Description = request.Description,
            SKU = request.SKU,
            Price = request.Price,
            CategoryId = request.CategoryId,
            Category = null,
            Inventory = new Inventory
            {
                Quantity = request.Quantity,
                ProductId = request.ProductId,
                Product = null
            }
        };
    }

    private static double GetProductRating(Product product)
    {
        if (product.Reviews is null || !product.Reviews.Any())
            return 0;

        return product.Reviews.Average(r => r.Rating);
    }
}
