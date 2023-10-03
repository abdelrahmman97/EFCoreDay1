using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class shop
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public byte[] ShopLogo { get; set; }

        public int OwnerID { get; set; }
        public User Owner { get; set; }
        public ICollection<product> Products { get; set; }
    }
}
