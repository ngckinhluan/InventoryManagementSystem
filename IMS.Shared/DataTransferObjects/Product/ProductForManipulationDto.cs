using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Shared.DataTransferObjects.Product
{
    public record ProductForManipulationDto
    {
        public string? ProductName { get; set; }

        public int? CategoryId { get; set; }

        public int? SupplierId { get; set; }

        public decimal? UnitPrice { get; set; }

        public string? QuantityPerUnit { get; set; }

        public int? ReorderLevel { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
