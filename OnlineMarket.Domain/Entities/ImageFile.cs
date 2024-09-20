using OnlineMarket.Domain.Common;

namespace OnlineMarket.Domain.Entities;

public class ImageFile : EntityBase
{
    public required string Name { get; set; }
    public required byte[] Data { get; set; }
    public required string Type { get; set; }

    public int ProductId { get; set; }
    public required virtual Product Product { get; set; }
}
