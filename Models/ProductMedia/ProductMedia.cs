namespace EFCoreDay1.Models
{
    public class ProductMedia
    {
        public Guid ID { get; set; }
        public string MeadiUrl { get; set; }
        public Guid ProductID { get; set; }

        public Product Product { get; set; }
    }
}