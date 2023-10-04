namespace EFCoreDay1.Models
{
    public class ProductCategory
    {
        public Guid ID { get; set; }
        public string Catagory { get; set; }

        public ICollection<Product> Prouducts { get; set; }

    }
}