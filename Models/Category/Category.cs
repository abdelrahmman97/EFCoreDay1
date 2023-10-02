namespace EFCoreDay1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; } 
        public string Catagory { get; set; }

    }
}