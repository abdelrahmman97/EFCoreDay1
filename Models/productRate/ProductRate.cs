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
        public float Rate { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int customerID { get; set; }
        public User user { get; set; }


    }
}
