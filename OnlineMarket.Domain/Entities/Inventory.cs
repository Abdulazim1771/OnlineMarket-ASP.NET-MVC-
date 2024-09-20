using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Inventory : AuditableEntity
{
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public required virtual Product Product { get; set; }
    public DateTime? DeletedAt { get; set; }
}
