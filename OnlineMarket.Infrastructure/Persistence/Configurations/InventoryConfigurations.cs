using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Infrastructure.Persistence.Configurations;

public class InventoryConfigurations : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable(nameof(Inventory));
        builder.HasKey(i => i.Id);

        builder
            .HasOne(i => i.Product)
            .WithOne(i => i.Inventory)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder
            .Property(i => i.Quantity)
            .IsRequired();         
    }
}
