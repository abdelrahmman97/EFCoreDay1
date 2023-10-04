using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class Shop
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }

        public User Owner { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
