using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stoke { get; set; }

        public int CategoryID { get; set; }
        public int ShopID { get; set; }


        public ICollection<ProductMedia> productMedias { get; set; }
        public ICollection<ProductRate>ProductRates { get; set; }
        public Category Category { get; set; }
        public shop Shop { get; set; }
    }
}
