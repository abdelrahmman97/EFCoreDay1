using EFCoreDay1.Models;
namespace EFCoreDay1.Models
{
    public class RequestOffers
    {
        public int ID { get; set; }
        public int ProviderID { get; set; }


        public bool state { get; set; }

        public bool Direct { get; set; }

        public Request Request { get; set; }

        public User User { get; set; }  
    }
}
