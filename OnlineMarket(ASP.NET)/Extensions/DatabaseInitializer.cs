using Bogus;
using Microsoft.AspNetCore.Identity;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Infrastructure.Persistence;
using Syncfusion.EJ2.Grids;

namespace OnlineMarket_ASP.NET_.Extensions;

public static class DatabaseInitializer
{
    private readonly static Faker _faker = new();

    public static void UseDatabaseInitializer(this WebApplication app)
    {
        try
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<OnlineMarketDbContext>();          
           
            CreateCategories(context);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to seed database. {ex.Message}");
        }
    }

    private static void CreateCategories(OnlineMarketDbContext context)
    {
        if (context.Categories.Any()) return;

        for (int i = 0; i < 20; i++)
        {       
            var category = new Category
            {    
                Name = _faker.Lorem.Word(),
                Description = _faker.Lorem.Sentence(),
            };

            context.Add(category);
        }

        context.SaveChanges();
    }
}
