using CleanArchMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMVC.Data.EntitiesConfiguration
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(column => column.Id);
            builder.Property(column => column.Name).HasMaxLength(100).IsRequired();
            builder.Property(column => column.Description).HasMaxLength(200).IsRequired();
            builder.Property(column => column.Price).HasPrecision(10, 2);

            builder.HasOne(column => column.Category).WithMany(columnTableCategories => columnTableCategories.Products)
                .HasForeignKey(column => column.CategoryId);
        }
    }
}