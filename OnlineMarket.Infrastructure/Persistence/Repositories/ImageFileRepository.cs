using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ImageFileRepository : RepositoryBase<ImageFile>, IImageFileRepository
{
    public ImageFileRepository(OnlineMarketDbContext context)
        : base(context)
    {        
    }

    public override List<ImageFile> GetAll(Guid userId)
    {
        throw new NotImplementedException();
    }

    public List<ImageFile> GetByProductId(int productId)
    {
        throw new NotImplementedException();
    }
}
