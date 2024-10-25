using OnlineMarket.Application.ViewModels.Category;
using OnlineMarket.Application.ViewModels.Review;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.ViewModels.Product;

public class ProductViewModel
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string SKU { get; init; }
    public required decimal Price { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public DateTime? DeletedAt { get; set; }
    public string CategoryName { get; set; }
    public required CategoryViewModel Category { get; set; }
    public int Quantity { get; set; }
    public required Inventory Inventory { get; init; }

    public double ProductRating { get; set; }
    public List<ReviewViewModel> Reviews { get; init; }
    public List<string> Images { get; init; }
    public ProductViewModel()
    {
        Images = [];
        Reviews = [];
    }
}
