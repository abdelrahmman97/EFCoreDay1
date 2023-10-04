

namespace EFCoreDay1.Models
{
    public class RequestMedia
    {
        public Guid ID { get; set; }
        public string MediaUrl { get; set; }
        public Guid RequestID { get; set; }

        public  Request Request { get; set; }
    }
}
