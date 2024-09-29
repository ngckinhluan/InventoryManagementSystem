using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Repositories.Interface
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        //ICategoryRepository Category { get; }
        //IOrderRepository Order { get; }
        //IOrderDetailRepository OrderDetail { get; }
        //ICustomerRepository Customer { get; }
        //IEmployeeRepository Employee { get; }
        //IShipperRepository Shipper { get; }
        //IOrderStatusRepository OrderStatus { get; }
        //IOrderDetailStatusRepository OrderDetailStatus { get; }
        //IOrderDetailStatusHistoryRepository OrderDetailStatusHistory { get; }
        //IOrderStatusHistoryRepository OrderStatusHistory { get; }
        Task SaveAsync();
    }
}
