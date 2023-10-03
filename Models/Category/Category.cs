namespace EFCoreDay1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Catagory { get; set; }

        public ICollection<product> Prouducts { get; set; }

    }
}