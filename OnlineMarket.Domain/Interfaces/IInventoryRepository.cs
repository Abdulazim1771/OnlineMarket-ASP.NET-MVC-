using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IInventoryRepository : IRepositoryBase<Inventory>
{
    List<Inventory> GetAll();
}
