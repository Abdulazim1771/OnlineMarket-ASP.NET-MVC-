using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(OnlineMarketDbContext context)
        : base(context)
    {
        
    }

    public override List<Order> GetAll()
    {
        throw new NotImplementedException();
    }
}
