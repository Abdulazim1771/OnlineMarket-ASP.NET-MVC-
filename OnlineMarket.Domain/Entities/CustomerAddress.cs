using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class CustomerAddress : AuditableEntity
{
    public required string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }

    public required string CustomerId { get; set; }
    public required Customer Customer { get; set; }
}
