


namespace EFCoreDay1.Models
{
    public class ServiceRate
    {
        public Guid ID { get; set; }
        public Guid ServiceID { get; set; }
        public Guid UserID { get; set; }
        public string Message { get; set; }
        public float NominateToOthers { get; set; }
        public float WorkQuality { get; set; }
        public float RespectDeliveryTime { get; set; }

        public User User { get; set; }
        public Service Service { get; set; }
    }
}
