using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        public Guid Id { get; }

        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTimeOffset BookmarkedAt { get; }

        public Bookmark(Guid userId, Guid tweetId)
        {
            Id = new Guid();
            UserId = userId;
            TweetId = tweetId;
            BookmarkedAt = DateTimeOffset.UtcNow;
        }
    }
}
