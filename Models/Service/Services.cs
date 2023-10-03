

namespace EFCoreDay1.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; }
        public int CategoryID { get; set; }
        public int ProviderID { get; set; }

        public User User { get; set; }
        public ServiceCategory ServiceCategory { get; set; }

    }
}
