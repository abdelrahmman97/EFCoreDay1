using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ProductRate
    {
        public Guid ID { get; set; }
        public float Rate { get; set; }
        public string Description { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerID { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
