using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(OnlineMarketDbContext context)
        : base(context)
    {
        
    }

    public List<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<Order> GetAll(string customerId)
    {
        throw new NotImplementedException();
    }
}
