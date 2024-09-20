using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Product : AuditableEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string SKU { get; set; }
    public required decimal Price { get; set; }
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
    public DateTime? DeletedAt { get; set; }

    public required Inventory Inventory { get; set; }

    public virtual ICollection<ImageFile> Images { get; set; }

    //public ICollection<OrderDetail> OrderDetails { get; set; }

    //public ICollection<Review> Reviews { get; set; }

    public Product()
    {
        Images = [];
    }
}
