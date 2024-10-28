using Microsoft.AspNetCore.Http;
using OnlineMarket.Application.Mappings;
using OnlineMarket.Application.Requests.Product;
using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket.Application.ViewModels.Product;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Application.Stores;

public class ProductStore : IProductStore
{
    private readonly ICommonRepository _repository;

    public ProductStore(ICommonRepository repository)
    {
        _repository = repository;
    }

    public List<ProductViewModel> GetAll(GetProductsRequest request)
    {
        var products = _repository.Products.GetAll(request.categoryId, request.search);
        var viewModels = products.Select(p => p.ToViewModel()).ToList();

        return viewModels;
    }

    public ProductViewModel GetProductById(ProductRequest request)
    {
        var product = _repository.Products.GetById(request.Id);
        product.Images = _repository.ImageFiles.GetByProductId(request.Id);
        var viewModel = product.ToViewModel();

        return viewModel;
    }

    public ProductViewModel Create(CreateProductRequest request, IEnumerable<IFormFile> attachments)
    {
        ArgumentNullException.ThrowIfNull(request);

        var entity = request.ToEntity();

        var createProduct = _repository.Products.Create(entity);

        foreach (var image in attachments)
        {
            using var stream = new MemoryStream();
            image.CopyTo(stream);

            var imageFile = new ImageFile
            {
                Name = image.FileName,
                Type = image.ContentType,
                Data = stream.ToArray(),
                Product = createProduct,
            };

            _repository.ImageFiles.Create(imageFile);
        }

        _repository.SaveChanges(); // ACID -> Atomicity

        var viewModel = createProduct.ToViewModel();

        return viewModel;
    }

    public void Update(UpdateProductRequest request)
    {
        throw new NotImplementedException();
    }

    public void Delete(ProductRequest request)
    {
        throw new NotImplementedException();
    }
}
