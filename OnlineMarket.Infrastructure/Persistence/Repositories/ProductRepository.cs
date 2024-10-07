using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(OnlineMarketDbContext context)
        : base(context)
    {       
    }

    public List<Product> GetAll(string? search)
    {
        throw new NotImplementedException();
    }

    public override List<Product> GetAll(Guid userId)
    {
        throw new NotImplementedException();
    }
}
