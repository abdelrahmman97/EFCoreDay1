using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;

namespace EFCoreDay1.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string SSN { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string ProfilePic { get; set; }
        public Guid RoleID { get; set; }


        public Shop Shop { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<RequestOffer> RequestOffer { get; set; }
        public ICollection<Request> Request { get; set; }
        public ICollection<Chat> Chats { get; set; }



    }
}
