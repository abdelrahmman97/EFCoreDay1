using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay1.Models
{
    public class Chat
    {
        public Guid ID { get; set; }
        public Guid FirstUserId { get; set; }
        public Guid SecondUserId { get; set; }
        public Guid RequestID { get; set; }

        public User User { get; set; }
        public Request Request { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
