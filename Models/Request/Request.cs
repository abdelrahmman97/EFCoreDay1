

namespace EFCoreDay1.Models
{
    public class Request
    {
        public int ID { get; set; }
        public int CleintID { get; set; }
        public string Details { get; set; }
        public decimal ExpectSalary { get; set; }
        public Boolean State {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RateValue { get; set; }
        public string RateMassage { get; set; }

        public ICollection<Media>  Media { get; set; }
        public DirectRequest DirectRequest { get; set; }
        //CLIENT
    }
}
