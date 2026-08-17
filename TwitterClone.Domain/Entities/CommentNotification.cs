using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public Guid CommentedByUserId { get; set; }

        public CommentNotification(Guid commentedByUserId) : base("Comment")
        {
            CommentedByUserId = commentedByUserId;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, CommentedByUserId: {CommentedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommentedByUserId} commented on your post.";

        }
    }
}
