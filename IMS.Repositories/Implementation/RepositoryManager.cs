using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.BusinessObjects.Models;
using IMS.Repositories.Interface;

namespace IMS.Repositories.Implementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly InventoryManagementSystemContext _context;
        private readonly Lazy<IProductRepository> _productRepository;

        public RepositoryManager(InventoryManagementSystemContext context)
        {
            _context = context;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
        }

        public IProductRepository Product => _productRepository.Value;
        public async Task SaveAsync() => await _context.SaveChangesAsync();

    }
}
