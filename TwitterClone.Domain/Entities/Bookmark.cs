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

        public DateTime BookmarkedAt { get; }
    }
}
