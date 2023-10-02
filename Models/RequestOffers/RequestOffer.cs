using EFCoreDay1.Models;
namespace EFCoreDay1.Models
{
    public class RequestOffer
    {
        public int ID { get; set; }
        public int ProviderID { get; set; }
        public int State { get; set; }
        public bool IsDirect { get; set; }
        public int RequestID { get; set; }

        public Request Request { get; set; }
        public User User { get; set; }
    }
}
