

namespace EFCoreDay1.Models
{
    public class Service
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; }
        public Guid CategoryID { get; set; }
        public Guid ProviderID { get; set; }

        public User User { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public ICollection<ServiceRate> ServiceRates { get; set; }

    }
}
