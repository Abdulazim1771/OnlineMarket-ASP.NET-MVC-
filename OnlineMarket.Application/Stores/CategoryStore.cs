using OnlineMarket.Application.Mappings;
using OnlineMarket.Application.Requests.Category;
using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket.Application.ViewModels.Category;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Application.Stores;

public class CategoryStore : ICategoryStore
{
    private readonly ICommonRepository _repository;

    public CategoryStore(ICommonRepository repository)
    {
        _repository = repository;
    }

    public List<CategoryViewModel> GetAll(GetCategoriesRequest request)
    {
        var entities = _repository.Categories.GetAll(request.Search);
        var viewModels = entities.Select(x => x.ToViewModel()).ToList();

        return viewModels;
    }

    public CategoryViewModel GetById(CategoryRequest request)
    {
        var entity = _repository.Categories.GetById(request.Id);

        return entity.ToViewModel();
    }

    public CategoryViewModel Create(CreateCategoryRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var entity = request.ToEntity();

        var createdEntity = _repository.Categories.Create(entity);
        _repository.SaveChanges();

        return createdEntity.ToViewModel();
    }

//    public void Update(UpdateCategoryRequest request)
//    {
//        ArgumentNullException.ThrowIfNull(request);

//        var entity = request.ToEntity();

//        try
//        {
//            _repository.Categories.Update(entity);
//            _repository.SaveChanges();
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!_repository.Categories.Exists(request.Id))
//            {
//                throw new EntityNotFoundException($"Category with id: {request.Id} is not found.");
//            }
//        }
//    }
}
