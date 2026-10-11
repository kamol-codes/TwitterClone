namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikable
    {
        public Guid AuthorId { get; private set; }

        public string Content { get; private set; }
        public static int MaxContentLength = 200;


        public Tweet(Guid authorId, string content) : base(Guid.NewGuid())
        {
            AuthorId = authorId;
            Content = content;
        }

        public void UpdateTweet(string content)
        {
            Content = content;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, AuthorId: {AuthorId}, Content: {Content}";
        }

        public bool CanBeLiked()
        {
            return true;
        }
    }
}


