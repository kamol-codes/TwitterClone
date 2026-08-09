using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; }

        public Guid SenderId { get; }

        public Guid ReceiverId { get; }

        public string Content { get; set; }

        public DateTime SentAt { get; }

        public bool IsRead { get; set; }
    }
}
