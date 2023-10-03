

namespace EFCoreDay1.Models
{
    public class Request
    {
        public int ID { get; set; }
        public int CleintID { get; set; }
        public string Details { get; set; }
        public decimal ExpectSalary { get; set; }
        public int State {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RateValue { get; set; }
        public string RateMassage { get; set; }

        public ICollection<RequestMedia> Media { get; set; }
        public ICollection<RequestOffer> RequestOffer { get; set; }
        public User User { get; set; }
    }
}
