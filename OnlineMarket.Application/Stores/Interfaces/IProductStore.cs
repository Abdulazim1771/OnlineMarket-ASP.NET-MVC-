using Microsoft.AspNetCore.Http;
using OnlineMarket.Application.Requests.Product;
using OnlineMarket.Application.ViewModels.Product;

namespace OnlineMarket.Application.Stores.Interfaces;

public interface IProductStore
{
    List<ProductViewModel> GetAll(GetProductsRequest request);
    ProductViewModel GetProductById(ProductRequest request);
    ProductViewModel Create(CreateProductRequest request, IEnumerable<IFormFile> attachments);
    void Update(UpdateProductRequest request);
    void Delete(ProductRequest request);
}
