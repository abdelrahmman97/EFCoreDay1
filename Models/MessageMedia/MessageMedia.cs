using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDay1.Models
{
    public class MessageMedia
    {
        public Guid ID { get; set; }
        public byte[] Content { get; set; }
        public Guid MessageID { get; set; }

        public Message Message { get; set; }
    }
}
