using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        public Guid UserId { get; }

        public Guid TweetId { get; }

        public DateTime LikedAt { get; }
    }
}
