using Microsoft.AspNetCore.Identity;
using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Order : AuditableEntity
{
    public decimal TotalPrice { get; set; }

    public required string CustomerId { get; set; }
    public required Customer Customer { get; set; }

    public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    public Order()
    {
        OrderDetails = [];
    }
}
