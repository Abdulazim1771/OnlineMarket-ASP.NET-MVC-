using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class CommonRepository : ICommonRepository
{
    private readonly OnlineMarketDbContext _context;


    private readonly ICategoryRepository _categories;
    public ICategoryRepository Categories => _categories;


    private readonly ICustomerAddressRepository _customerAddresses;
    public ICustomerAddressRepository CustomerAddresses => _customerAddresses;


    private readonly ICustomerRepository _customers;
    public ICustomerRepository Customers => _customers;


    private readonly IOrderRepository _orders;
    public IOrderRepository Orders => _orders;

    private readonly IOrderDetailRepository _orderDetails;
    public IOrderDetailRepository OrderDetails => _orderDetails;


    private readonly IProductRepository _products;
    public IProductRepository Products => _products;


    private readonly IInventoryRepository _inventories;
    public IInventoryRepository Inventories => _inventories;


    private readonly IImageFileRepository _imageFiles;
    public IImageFileRepository ImageFiles => _imageFiles;


    private readonly IReviewRepository _reviews;
    public IReviewRepository Reviews => _reviews;

    public CommonRepository(OnlineMarketDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        
        _categories = new CategoryRepository(context);
        _customers = new CustomerRepository(context);
        _customerAddresses = new CustomerAddressRepository(context);
        _products = new ProductRepository(context);
        _inventories = new InventoryRepository(context);
        _imageFiles = new ImageFileRepository(context);
        _orders = new OrderRepository(context);
        _orderDetails = new OrderDetailRepository(context);
        _reviews = new ReviewRepository(context);
    }

    public int SaveChanges() => _context.SaveChanges();
}
