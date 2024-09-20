using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Category : AuditableEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; }

    public Category()
    {
        Products = [];
    }
}
