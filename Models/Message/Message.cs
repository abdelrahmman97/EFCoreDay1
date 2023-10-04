
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class Message
    {
        public Guid ID { get; set; }
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Chat Chat { get; set; }
        public ICollection<MessageMedia> MessageMedias { get; set; }

    }
}
