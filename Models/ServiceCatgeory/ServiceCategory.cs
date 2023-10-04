

namespace EFCoreDay1.Models
{
    public class ServiceCategory
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public ICollection<Service> Services { get; set; }
    }

}
