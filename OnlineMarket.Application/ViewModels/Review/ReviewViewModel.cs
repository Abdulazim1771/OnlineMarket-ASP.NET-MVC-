using OnlineMarket.Application.ViewModels.Customer;
using OnlineMarket.Application.ViewModels.Product;

namespace OnlineMarket.Application.ViewModels.Review;

public class ReviewViewModel
{
    public int Id { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public DateTime? DeletedAt { get; init; }
    public required string Comment { get; init; }
    public double Rating { get; init; }
    public required ProductViewModel Product { get; set; }
    public required CustomerViewModel Customer { get; set; }
}
