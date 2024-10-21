using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(OnlineMarketDbContext context)
        : base(context)
    {       
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<Product> GetAll(string customerId)
    {
        throw new NotImplementedException();
    }

}
