using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class Review : AuditableEntity
{
    public int ProductId { get; set; }
    public required Product Product { get; set; }

    public required string CustomerId { get; set; }
    public required Customer Customer { get; set; }

    public double Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? DeletedAt { get; set; }
}
