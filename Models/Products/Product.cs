using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EFCoreDay1.Models;

namespace EFCoreDay1.Models
{
    public class Product
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitePrice { get; set; } 
        public int  mediaId { get; set; }
        public int Stock {  get; set; }
        public int  shopId { get; set; }
        public  int  categoryId { get; set; }



    }
}
