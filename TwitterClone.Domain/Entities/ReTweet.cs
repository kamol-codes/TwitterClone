//namespace TwitterClone.Domain.Entities
//{
//    public class Retweet : BaseEntity
//    {
//        public string Comment { get; set; }
//        public Guid UserId { get; set; }

//        public Guid TweetId { get; set; }

//        public DateTimeOffset RetweetedAt { get; }

//        public Retweet() : base(Guid.NewGuid())
//        {

//        }

//        public override string DescribeRecord()
//        {
//            var baseRecord = base.DescribeRecord();
//            return $"{baseRecord},Comment: {Comment}, UserId: {UserId}, TweetId: {TweetId}";
//        }

//        public void MarkAsModified()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

using TwitterClone.Domain.Entities;

public class Retweet : BaseEntity
{
    public string Comment { get; private set; }
    public Guid UserId { get; private set; }
    public Guid TweetId { get; private set; }
    public DateTimeOffset RetweetedAt { get; private set; }

    public Retweet(Guid userId, Guid tweetId, string comment)
        : base(Guid.NewGuid())
    {
        UserId = userId;
        TweetId = tweetId;
        Comment = comment;
        RetweetedAt = DateTimeOffset.UtcNow;
    }

    private Retweet() : base(Guid.Empty)
    {
    }

    public void UpdateComment(string comment)
    {
        if (string.IsNullOrWhiteSpace(comment))
            throw new ArgumentException("Comment cannot be empty.");

        Comment = comment;
    }

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();

        return $"{baseRecord}, Comment: {Comment}, " +
               $"UserId: {UserId}, TweetId: {TweetId}, " +
               $"RetweetedAt: {RetweetedAt}";
    }


}