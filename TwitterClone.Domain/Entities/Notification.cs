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

        public DateTimeOffset CreatedAt { get; }

        public bool IsRead { get; set; }

        public Notification(Guid id, Guid userId, Guid actorId, string type, Guid? tweetId)
        {
            Id = new Guid();
            UserId = userId;
            ActorId = actorId;
            Type = type;
            TweetId = tweetId;
            CreatedAt = DateTimeOffset.UtcNow;
        }

    }
}
