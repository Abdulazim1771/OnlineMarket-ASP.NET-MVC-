using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(OnlineMarketDbContext context)
        : base(context)
    {        
    }

    public List<OrderDetail> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<OrderDetail> GetAll(string customerId)
    {
        throw new NotImplementedException();
    }
}
