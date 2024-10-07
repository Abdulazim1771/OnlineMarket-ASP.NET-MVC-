namespace OnlineMarket.Domain.Interfaces;

public interface ICommonRepository
{
    IProductRepository Products { get; }
    ICategoryRepository Categories { get; }
    IInventoryRepository Inventories { get; }
    IImageFileRepository ImageFiles { get; }
    IReviewRepository Reviews { get; }

    public int SaveChanges();
}
