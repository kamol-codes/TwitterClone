using TwitterClone.Application.Interfaces;

namespace TwitterClone.Infrastructure.Repositories
{
    public class RetweetRepository : IRetweetRepository
    {

        private readonly List<Retweet> _Retweets = new List<Retweet>();

        public Retweet AddRetweet(Retweet Retweet)
        {
            _Retweets.Add(Retweet);

            return Retweet;
        }

        public Retweet UpdateRetweet(Retweet Retweet)
        {
            _Retweets.RemoveAll(r => r.Id == Retweet.Id);
            _Retweets.Add(Retweet);
            return Retweet;
        }

        public bool DeleteRetweet(Retweet Retweet)
        {
            return _Retweets.Remove(Retweet);
        }

        public int DeleteRetweetsByUserId(Guid userId)
        {
            return _Retweets.RemoveAll(r => r.UserId == userId);
        }

        public int DeleteRetweetsByTweetId(Guid tweetId)
        {
            return _Retweets.RemoveAll(r => r.TweetId == tweetId);
        }

        public Retweet? GetRetweetById(Guid id)
        {
            return _Retweets.SingleOrDefault(r => r.Id == id);
        }

        public List<Retweet> GetRetweets(Guid? userId, Guid? tweetId)
        {
            return _Retweets
                .Where(r => (userId == null || r.UserId == userId) &&
                            (tweetId == null || r.TweetId == tweetId))
                .ToList();
        }
    }
}
