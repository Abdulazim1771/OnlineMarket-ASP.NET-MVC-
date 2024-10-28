using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ImageFileRepository : RepositoryBase<ImageFile>, IImageFileRepository
{
    public ImageFileRepository(OnlineMarketDbContext context)
        : base(context)
    {        
    }

    public override List<ImageFile> GetAll()
    {
        var images = _context.ImageFiles
            .AsNoTracking()  
            .ToList();

        return images;
    }

    public List<ImageFile> GetByProductId(int productId)
    {
        var images = _context.ImageFiles
            .AsNoTracking()
            .Where(x => x.ProductId == productId)
            .ToList();

        return images;
    }
}
