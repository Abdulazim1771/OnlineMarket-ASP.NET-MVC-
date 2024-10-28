using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ReviewRepository : RepositoryBase<Review>, IReviewRepository
{
    public ReviewRepository(OnlineMarketDbContext context)
        : base(context)
    { 
    }

    public List<Review> GetAll(int productId)
    {
        var reviews = _context.Reviews
            .AsNoTracking()
            .Where(r => r.ProductId == productId)
            .ToList();

        return reviews;
    }

    public override List<Review> GetAll()
    {
        throw new NotImplementedException();
    }
}
