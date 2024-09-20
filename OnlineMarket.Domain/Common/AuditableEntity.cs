namespace OnlineMarket.Domain.Common;

public abstract class AuditableEntity : EntityBase
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
