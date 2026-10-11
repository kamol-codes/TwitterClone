namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public string Message { get; }

        public SystemNotification() : base("System")
        {
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }

        public override string GetMessage()
        {
            return $"System Notification: {Message}";
        }
    }
}
