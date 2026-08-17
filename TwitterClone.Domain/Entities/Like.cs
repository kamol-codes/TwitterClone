using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        public Guid Id { get; }
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTimeOffset LikedAt { get; }

        public Like(Guid userId, Guid tweetId)
        {
            Id = new Guid();
            UserId = userId;
            TweetId = tweetId;
            LikedAt = DateTimeOffset.UtcNow;
        }
    }
}
