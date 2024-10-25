using OnlineMarket.Application.ViewModels.Customer;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.ViewModels.Order;

public class OrderViewModel
{
    public int Id { get; init; }
    public decimal TotalPrice { get; init; }

    public required CustomerViewModel Customer { get; init; }
    public List<OrderDetail> OrderDetails { get; init; }
    public OrderViewModel()
    {
        OrderDetails = [];
    }
}
