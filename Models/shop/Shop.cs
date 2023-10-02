namespace EFCoreDay1.Models
{
    public class Shop
    {
         public int Id { get; set; }
        public string  Title { get; set; }
        public string Address { get; set; }
        public string shopIamge { get; set; }
        public int OwnerId {  get; set; }
        public ICollection<Product> Products{ get; set; }
    }
}