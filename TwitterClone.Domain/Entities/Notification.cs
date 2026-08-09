using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; }

        public Guid UserId { get; }

        public Guid ActorId { get; }

        public string Type { get; }

        public Guid? TweetId { get; }

        public DateTime CreatedAt { get; }

        public bool IsRead { get; set; }
    }
}
