using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FreiendRequestNotification : Notification
    {
        public Guid RequestedByUserId { get; set; }

        public FreiendRequestNotification(Guid requestedByUserId) : base("FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
    }
}
