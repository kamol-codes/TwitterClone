using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{

    public class Follow
    {
        public Guid Id { get; }

        public Guid FollowerId { get; }

        public Guid FollowingId { get; }

        public DateTime FollowedAt { get; }
    }
}

