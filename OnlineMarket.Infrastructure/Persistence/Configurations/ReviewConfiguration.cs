using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Infrastructure.Persistence.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable(nameof(Review));
        builder.HasKey(r => r.Id);

        builder
            .HasOne(r => r.Product)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder
            .HasOne(r => r.Customer)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);


        builder
            .Property(r => r.Rating)
            .HasPrecision(2, 1)
            .IsRequired();

        builder
            .Property(r => r.Comment)
            .HasMaxLength(Constants.MAX_STRING_LENGTH)
            .IsRequired(false);
    }
}
