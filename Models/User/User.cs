using System.Net;

namespace EFCoreDay1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string SSN { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSlat { get; set; }
        public string ProfilePic { get; set; }
        public int RoleID { get; set; }


        public int shopID { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<RequestOffer> RequestOffer { get; set; }
        public ICollection<Request> Request { get; set; }
        public shop Shop { get; set; }



    }
}
