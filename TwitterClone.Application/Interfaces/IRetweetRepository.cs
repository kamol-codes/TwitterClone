namespace TwitterClone.Application.Interfaces
{
    public interface IRetweetRepository
    {
        Retweet AddRetweet(Retweet Retweet);
        Retweet UpdateRetweet(Retweet Retweet);
        bool DeleteRetweet(Retweet Retweet);
        int DeleteRetweetsByUserId(Guid userId);
        int DeleteRetweetsByTweetId(Guid tweetId);
        Retweet? GetRetweetById(Guid id);
        List<Retweet> GetRetweets(Guid? userId, Guid? tweetId);

    }
}
