using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{

    public class Follow : BaseEntity
    {

        public Guid FollowerId { get; }

        public Guid FollowingId { get; }

        public Follow(Guid followerId, Guid followingId):base(new Guid())
        {
            FollowerId = followerId;
            FollowingId = followingId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId: {FollowerId}, FollowingId: {FollowingId}";
        }
    }
}

