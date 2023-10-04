using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class Message
    {
        public int ID { get; set; }
        public int ChatId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Chat Chat { get; set; }

    }
}
