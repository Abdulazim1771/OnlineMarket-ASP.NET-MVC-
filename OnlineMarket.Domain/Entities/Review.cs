using OnlineMarket.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMarket.Domain.Entities;

public class Review : AuditableEntity
{
    public int ProductId { get; set; }
    public required Product Product { get; set; }

    //public int CustomerId { get; set; }
    //public Customer Customer { get; set; }

    public double Rating { get; set; }
    public string? Comment { get; set; }
}
