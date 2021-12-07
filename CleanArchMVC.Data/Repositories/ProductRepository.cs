using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchMVC.Data.Context;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMVC.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _dbContext.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _dbContext.Products.FindAsync(id);
        }


        public async Task<Product> GetProductCategoryAsync(int? id)
        {
           return await _dbContext.Products
                    .Include(table => table.Category)
                    .SingleOrDefaultAsync(column => column.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _dbContext.Products.ToArrayAsync();
        }

        public async Task<Product> RemoveProductAsync(Product product)
        {
            _dbContext.Remove(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
           _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }
    }
}