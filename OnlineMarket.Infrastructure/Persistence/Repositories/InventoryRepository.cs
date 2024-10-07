using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
{
    public InventoryRepository(OnlineMarketDbContext context)
        : base(context)
    {
    }

    public List<Inventory> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<Inventory> GetAll(Guid userId)
    {
        throw new NotImplementedException();
    }
}
