using IMS.BusinessObjects.Models;
using IMS.Shared.DataTransferObjects.Product;

namespace IMS.Services.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges);
        Task<ProductDto?> GetProductByIdAsync(int productId, bool trackChanges);
        Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        Task UpdateProductAsync(int id, ProductForUpdateDto product, bool trackChanges);
        Task DeleteProductAsync(int id, bool trackChanges);
    }
}
