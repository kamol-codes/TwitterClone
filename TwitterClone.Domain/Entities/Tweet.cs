namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikable
    {
        public Guid AuthorId { get; }

        public string Content { get; }

        public Tweet(Guid authorId, string content) : base(new Guid())
        {
            AuthorId = authorId;
            Content = content;
        }

        public Tweet(string content) : base(new Guid())
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


