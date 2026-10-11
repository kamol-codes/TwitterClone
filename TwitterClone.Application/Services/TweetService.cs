using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Application.Mappings;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Services
{
    public class TweetService : ITweetService
    {
        private readonly ITweetRepository _tweetRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILikeRepository _likeRepository;
        private readonly IBookmarkRepository _bookmarkRepository;
        private readonly IRetweetRepository _RetweetRepository;

        public TweetService(
            ITweetRepository tweetRepository,
            IUserRepository userRepository,
            ILikeRepository likeRepository,
            IBookmarkRepository bookmarkRepository,
            IRetweetRepository RetweetRepository)
        {
            _tweetRepository = tweetRepository;
            _userRepository = userRepository;
            _likeRepository = likeRepository;
            _bookmarkRepository = bookmarkRepository;
            _RetweetRepository = RetweetRepository;
        }

        public TweetDto? CreateTweet(CreateTweetDto createTweetDto)
        {
            if (!IsValidContent(createTweetDto.Content))
            {
                return null;
            }

            var user = _userRepository.GetUserById(createTweetDto.UserId);

            if (user == null)
            {
                return null;
            }

            var createdTweet = _tweetRepository.AddTweet(
                new Tweet(user.Id, createTweetDto.Content.Trim()));

            return createdTweet.ToDto();
        }

        public TweetDto? GetTweetById(Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            return tweet?.ToDto();
        }

        public List<TweetDto> GetTweets(Guid? userId)
        {
            var tweets = userId.HasValue
                ? _tweetRepository.GetTweetsByUserId(userId.Value)
                : _tweetRepository.GetTweets();

            // Newest first, like a timeline.
            return tweets
                .OrderByDescending(t => t.CreatedAt)
                .Select(t => t.ToDto())
                .ToList();
        }

        public TweetDto? UpdateTweet(Guid id, UpdateTweetDto updateTweetDto)
        {
            if (!IsValidContent(updateTweetDto.Content))
            {
                return null;
            }

            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return null;
            }

            tweet.UpdateTweet(updateTweetDto.Content.Trim());
            tweet.MarkAsModified();

            _tweetRepository.UpdateTweet(tweet);

            return tweet.ToDto();
        }

        public bool DeleteTweet(Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return false;
            }

            // Likes, bookmarks and Retweets can't outlive the tweet they point at.
            _likeRepository.DeleteLikesByTweetId(id);
            _bookmarkRepository.DeleteBookmarksByTweetId(id);
            _RetweetRepository.DeleteRetweetsByTweetId(id);

            return _tweetRepository.DeleteTweet(tweet);
        }

        private static bool IsValidContent(string content)
        {
            return !string.IsNullOrWhiteSpace(content) && content.Length <= Tweet.MaxContentLength;
        }
    }
}
