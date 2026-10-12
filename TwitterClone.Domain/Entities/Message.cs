namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; }

        public Guid ReceiverId { get; }

        public string Content { get; set; }

        public bool IsRead { get; set; }

        public DateTime SentAt { get; set; }


        public Message(Guid senderId, Guid receiverId, string content, DateTime sentAt, bool isRead) : base(Guid.NewGuid())
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
            SentAt = sentAt;
            IsRead = isRead;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, IsRead: {IsRead}";
        }
    }
}
