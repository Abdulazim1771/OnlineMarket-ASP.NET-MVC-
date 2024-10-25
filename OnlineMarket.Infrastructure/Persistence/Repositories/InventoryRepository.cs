using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
{
    public InventoryRepository(OnlineMarketDbContext context)
        : base(context)
    {
    }

    public override List<Inventory> GetAll()
    {
        throw new NotImplementedException();
    }
}
