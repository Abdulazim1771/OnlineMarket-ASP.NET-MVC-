using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class CustomerAddressRepository : RepositoryBase<CustomerAddress>, ICustomerAddressRepository
{
    public CustomerAddressRepository(OnlineMarketDbContext context)
        : base(context)
    {        
    }

    public override List<CustomerAddress> GetAll()
    {
        throw new NotImplementedException();
    }
}
