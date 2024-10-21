using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Exceptions;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class CustomerRepository : ICustomerRepository
{
    private readonly OnlineMarketDbContext _context;
    public CustomerRepository(OnlineMarketDbContext context)
    {
        _context = context;
    }

    public List<Customer> GetAll()
    {
        var customers = _context.Users.ToList();

        return customers;
    }

    public Customer GetById(string id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id);

        if (user == null)
        {
            throw new EntityNotFoundException($"User with id: {id} is not found");
        }

        return user;
    }
}
