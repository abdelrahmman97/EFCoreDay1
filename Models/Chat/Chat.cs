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
        public int ID { get; set; }
        public int FirstUserId { get; set; }
        public int SecondUserId { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
