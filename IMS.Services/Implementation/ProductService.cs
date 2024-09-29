using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IMS.Repositories.Interface;
using IMS.Services.Interface;
using IMS.Shared.DataTransferObjects.Product;

namespace IMS.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges)
        {
            var products = await _repositoryManager.Product.GetAllProductsAsync(trackChanges);
            var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
            return productDtos;
        }

        public async Task<ProductDto?> GetProductByIdAsync(int productId, bool trackChanges)
        {
            var product = await _repositoryManager.Product.GetProductByIdAsync(productId, trackChanges);
            if (product == null)
            {
                return null;
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;

        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto product)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProductAsync(int id, ProductForUpdateDto product, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProductAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
