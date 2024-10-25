using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ReviewRepository : RepositoryBase<Review>, IReviewRepository
{
    public ReviewRepository(OnlineMarketDbContext context)
        : base(context)
    { 
    }

    public override List<Review> GetAll()
    {
        throw new NotImplementedException();
    }
}
