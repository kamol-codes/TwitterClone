using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; }

        public Guid ReceiverId { get; }

        public string Content { get; set; }

        public bool IsRead { get; set; }


        public Message(Guid senderId, Guid receiverId, string content) : base(new Guid())
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, IsRead: {IsRead}";
        }
    }
}
