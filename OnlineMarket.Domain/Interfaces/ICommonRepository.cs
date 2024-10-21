namespace OnlineMarket.Domain.Interfaces;

public interface ICommonRepository
{
    ICategoryRepository Categories { get; }
    ICustomerAddressRepository CustomerAddresses { get; }
    ICustomerRepository Customers { get; }
    IImageFileRepository ImageFiles { get; }
    IInventoryRepository Inventories { get; }
    IOrderRepository Orders { get; }
    IOrderDetailRepository OrderDetails { get; }
    IProductRepository Products { get; }
    IReviewRepository Reviews { get; }

    public int SaveChanges();
}
