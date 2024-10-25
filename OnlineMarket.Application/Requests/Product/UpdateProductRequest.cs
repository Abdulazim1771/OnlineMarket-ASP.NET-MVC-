namespace OnlineMarket.Application.Requests.Product;

public sealed record UpdateProductRequest(
    string Name,
    string? Description,
    string SKU,
    decimal Price,
    int CategoryId,
    int Quantity,
    int ProductId) : CreateProductRequest(
    Name: Name,
    Description: Description,
    SKU: SKU,
    Price: Price,
    CategoryId: CategoryId,
    Quantity: Quantity,
    ProductId: ProductId);
