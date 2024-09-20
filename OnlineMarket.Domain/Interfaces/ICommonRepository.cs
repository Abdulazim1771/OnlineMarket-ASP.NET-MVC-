namespace OnlineMarket.Domain.Interfaces;

public interface ICommonRepository
{
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IInventoryRepository InventoryRepository { get; }

    public int SaveChanges();
}
