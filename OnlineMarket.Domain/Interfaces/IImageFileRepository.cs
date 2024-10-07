using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IImageFileRepository : IRepositoryBase<ImageFile>
{
    List<ImageFile> GetByProductId(int productId);
}
