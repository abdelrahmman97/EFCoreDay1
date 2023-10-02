using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ProductRate
    {
         public int Id { get; set; }
        public int productId { get; set; }

        public int CustomerID { get; set; }
        public float Value { get; set; }
        public string Massage {  get; set; }

        public Product Product { get; set; }

    }
}
