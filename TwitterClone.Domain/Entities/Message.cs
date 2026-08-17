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

        public DateTimeOffset SentAt { get; }

        public bool IsRead { get; set; }


        public Message(Guid senderId, Guid receiverId, string content)
        {
            Id = new Guid();
            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
            SentAt = DateTimeOffset.UtcNow;
        }
    }
}
