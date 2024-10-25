using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Application.Requests.Product;

public record CreateProductRequest(
    string Name,
    string? Description,
    string SKU,
    decimal Price,
    int CategoryId,
    int Quantity,
    int ProductId);
