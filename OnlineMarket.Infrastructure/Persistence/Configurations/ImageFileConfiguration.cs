using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Infrastructure.Persistence.Configurations;

internal class ImageFileConfiguration : IEntityTypeConfiguration<ImageFile>
{
    public void Configure(EntityTypeBuilder<ImageFile> builder)
    {
        builder.ToTable(nameof(ImageFile));
        builder.HasKey(i => i.Id);

        builder
            .HasOne(i => i.Product)
            .WithMany(p => p.Images)
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder
            .Property(i => i.Name)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();

        builder
            .Property(i => i.Data)
            .IsRequired();

        builder
            .Property(i => i.Type)
            .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
            .IsRequired();
    }
}
