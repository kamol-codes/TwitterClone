namespace TwitterClone.Domain.Entities
{
    abstract public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }

        public string NotificationType { get; set; }

        public bool IsRead { get; set; }

        protected string Message { get; set; }

        public string Type { get; set; }

        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            NotificationType = notificationType;
        }

        public string GetNotificationInformation()
        {
            return $"UsesId: {UserId}, NotificationType: {NotificationType}, Message: {Message}";
        }

        public override string DescribeRecord()
        {
            return $" Notification Class: Type: {NotificationType},Message: {Message}, IsRead: {IsRead}";
        }

        public abstract string GetMessage();
    }
}
