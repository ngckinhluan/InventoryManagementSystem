

using IMS.BusinessObjects.Models;
using System.Threading.Tasks;

namespace IMS.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        Task<Product?> GetProductByIdAsync(int productId, bool trackChanges);
        Task CreateProductAsync(Product product); 
        Task UpdateProductAsync(Product product); 
        Task DeleteProductAsync(Product product); 
    }
}
