using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class OrderDetail : AuditableEntity
{
    public int OrderId { get; set; }
    public required Order Order { get; set; }

    public int ProductId { get; set; }
    public required Product Product { get; set; }

    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
