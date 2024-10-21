using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Infrastructure.Persistence.Configurations;

internal class CustomerAddressConfigurations : IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
        builder.ToTable(nameof(CustomerAddress));
        builder.HasKey(ca => ca.Id);

        builder
            .HasOne(ca => ca.Customer)
            .WithMany(c => c.Addresses)
            .HasForeignKey(ca => ca.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .Property(ca => ca.AddressLine1)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();

        builder
            .Property(ca => ca.AddressLine2)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired(false);

        builder
            .Property(ca => ca.City)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();

        builder
            .Property(ca => ca.Country)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();
    }
}
