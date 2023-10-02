using EFCoreDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class ServicCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public ICollection<Service> Services { get; set; }
    }

}
