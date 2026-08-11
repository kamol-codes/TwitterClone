using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        public Guid Id { get; }
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTimeOffset RetweetedAt { get; }

        public ReTweet(Guid userId, Guid tweetId)
        {
            Id = new Guid();
            UserId = userId;
            TweetId = tweetId;
            RetweetedAt = DateTimeOffset.UtcNow;
        }
    }
}
