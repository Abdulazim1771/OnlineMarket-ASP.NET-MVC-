using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Order : AuditableEntity
{
    //public int CustomerId { get; set; }
    //public Customer Customer { get; set; }

    public decimal TotalPrice { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

    public Order()
    {
        OrderDetails = [];
    }
}
