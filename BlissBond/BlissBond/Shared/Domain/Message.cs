using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlissBond.Shared.Domain
{
    public class Message:BaseDomainModel
    {
        public int SenderId { get; set; } // User ID of the sender
        public int ReceiverId { get; set; } // User ID of the receiver
        public string Content { get; set; } // The content of the message
        public DateTime Timestamp { get; set; } // The time when the message was sent

        // Navigation properties for Entity Framework (if you're using it)
        public virtual ICollection<Match>? Matches { get; set; }
       
    }
}
