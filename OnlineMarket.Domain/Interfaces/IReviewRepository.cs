using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IReviewRepository : IRepositoryBase<Review>
{ 
    List<Review> GetAll(int productId);
}
