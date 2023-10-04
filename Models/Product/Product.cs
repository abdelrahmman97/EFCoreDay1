using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stoke { get; set; }
        public Guid CategoryID { get; set; }
        public Guid ShopID { get; set; }

        public Shop Shop { get; set; }
        public ProductCategory Category { get; set; }
        public ICollection<ProductMedia> ProductMedias { get; set; }
        public ICollection<ProductRate> ProductRates { get; set; }
    }
}
