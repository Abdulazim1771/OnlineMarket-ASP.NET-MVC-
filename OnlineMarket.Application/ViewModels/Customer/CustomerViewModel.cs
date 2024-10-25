using OnlineMarket.Application.ViewModels.Order;
using OnlineMarket.Application.ViewModels.Review;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.ViewModels.Customer;

public class CustomerViewModel
{
    public required string Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    public List<OrderViewModel> Orders { get; init; }
    public List<ReviewViewModel> Reviews { get; init; }
    public List<CustomerAddress> CustomerAddresses { get; set; }
    public CustomerViewModel()
    {
        Orders = [];
        CustomerAddresses = [];
        Reviews = [];
    }
}
