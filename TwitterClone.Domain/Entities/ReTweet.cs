using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTime RetweetedAt { get; }
    }
}
