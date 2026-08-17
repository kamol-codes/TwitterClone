using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace TwitterClone.Domain.Entities
{
    public class ReTweet : BaseEntity
    {
        public string Comment { get; }
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTimeOffset RetweetedAt { get; }

        public ReTweet(Guid userId, Guid tweetId) : base(new Guid())
        {
            UserId = userId;
            TweetId = tweetId;
            RetweetedAt = DateTimeOffset.UtcNow;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord},Comment: {Comment}, UserId: {UserId}, TweetId: {TweetId}";
        }
    }
}
