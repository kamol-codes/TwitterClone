using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikedByUserId { get; set; }

        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikedByUserId = likeByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikeByUserId: {LikedByUserId}";
        }
    }
}
