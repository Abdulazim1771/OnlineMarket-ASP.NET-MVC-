using Microsoft.AspNetCore.Identity;

namespace OnlineMarket.Domain.Entities;

public class Customer : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public ICollection<Order> Orders { get; set; }
    public ICollection<CustomerAddress> Addresses { get; set; }
    public ICollection<Review> Reviews { get; set; }

    public Customer()
    {
        Orders = [];
        Addresses = [];
        Reviews = [];
    }
}
