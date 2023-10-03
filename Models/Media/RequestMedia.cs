

namespace EFCoreDay1.Models
{
    public class RequestMedia
    {
        public int ID { get; set; }
        public string MediaUrl { get; set; }
        public int RequestID { get; set; }
        public  Request request { get; set; }
    }
}
