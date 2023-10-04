using EFCoreDay1.Models;
namespace EFCoreDay1.Models
{
    public class RequestOffer
    {
        public Guid ID { get; set; }
        public Guid ProviderID { get; set; }
        public int State { get; set; }
        public bool IsDirect { get; set; }
        public Guid RequestID { get; set; }

        public Request Request { get; set; }
        public User User { get; set; }
    }
}
