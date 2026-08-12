using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public Like(Guid userId, Guid tweetId) :base(new Guid())
        {
            UserId = userId;
            TweetId = tweetId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}";
        }
    }
}
