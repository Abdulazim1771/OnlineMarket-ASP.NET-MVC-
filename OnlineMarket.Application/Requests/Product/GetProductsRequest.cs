namespace OnlineMarket.Application.Requests.Product;

public record GetProductsRequest(int? categoryId, string? search);
