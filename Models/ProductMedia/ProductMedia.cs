namespace EFCoreDay1.Models
{
    public class ProductMedia
    {
        public int ID { get; set; }
        public string MeadiUrl { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}