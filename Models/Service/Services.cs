using EFCoreDay1.Models;
namespace EFCoreDay1.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; } 
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; } 
        public int  CategoryId { get; set; }
        public ServicCategory Category { get; set; }

        public int ProviderId { get; set; }
    
        public User User { get; set; }
        
    }
}
