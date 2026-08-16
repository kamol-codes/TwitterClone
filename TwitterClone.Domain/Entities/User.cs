namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        private List<Guid> Followers = new List<Guid>();
        private List<Guid> IncomingNotifications = new List<Guid>();

        public User() : base(new Guid())
        {

        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email},UserName: {Username}";
        }

        public void AddNotification(Guid notificationId)
        {
            if (!IncomingNotifications.Contains(notificationId)) { IncomingNotifications.Add(notificationId); }
        }

        public void Follow(Guid userId)
        {
            if (!Followers.Contains(userId))
            {
                Followers.Add(userId);
            }
        }

        public void UnFollow(Guid userId)
        {
            if (Followers.Contains(userId))
            {
                Followers.Remove(userId);
            }
        }
    }
}
