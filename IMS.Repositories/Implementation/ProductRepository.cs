using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.BusinessObjects.Models;
using IMS.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace IMS.Repositories.Implementation
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(InventoryManagementSystemContext context) : base(context)
        {
        }


        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges) => await FindAll(trackChanges)
            .OrderBy(p => p.ProductName)
            .ToListAsync();

        public async Task<Product?> GetProductByIdAsync(int productId, bool trackChanges) => await FindByCondition(p => p.ProductId == productId, trackChanges)
            .SingleOrDefaultAsync();

        public async Task CreateProductAsync(Product product)
        {
            Create(product); 
            await Context.SaveChangesAsync(); 
        }

        public async Task UpdateProductAsync(Product product)
        {
            Update(product);
            await Context.SaveChangesAsync(); 
        }

        public async Task DeleteProductAsync(Product product)
        {
            Delete(product); 
            await Context.SaveChangesAsync(); 
        }

    }
}
