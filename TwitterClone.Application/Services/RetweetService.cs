using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Application.Mappings;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Services
{
    public class RetweetService : IRetweetService
    {
        private readonly IRetweetRepository _RetweetRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITweetRepository _tweetRepository;

        public RetweetService(
            IRetweetRepository RetweetRepository,
            IUserRepository userRepository,
            ITweetRepository tweetRepository)
        {
            _RetweetRepository = RetweetRepository;
            _userRepository = userRepository;
            _tweetRepository = tweetRepository;
        }

        public RetweetDto? CreateRetweet(CreateRetweetDto createRetweetDto)
        {
            if (!IsValidComment(createRetweetDto.Comment))
            {
                return null;
            }

            if (_userRepository.GetUserById(createRetweetDto.UserId) == null ||
                _tweetRepository.GetTweetById(createRetweetDto.TweetId) == null)
            {
                return null;
            }

            var createdRetweet = _RetweetRepository.AddRetweet(new Retweet(
                    createRetweetDto.UserId,
                    createRetweetDto.TweetId,
                    createRetweetDto.Comment?.Trim() ?? string.Empty
                ));

            return createdRetweet.ToDto();
        }

        public RetweetDto? GetRetweetById(Guid id)
        {
            var Retweet = _RetweetRepository.GetRetweetById(id);

            return Retweet?.ToDto();
        }

        public List<RetweetDto> GetRetweets(Guid? userId, Guid? tweetId)
        {
            return _RetweetRepository.GetRetweets(userId, tweetId)
                .OrderByDescending(r => r.CreatedAt)
                .Select(r => r.ToDto())
                .ToList();
        }

        public RetweetDto? UpdateRetweet(Guid id, UpdateRetweetDto updateRetweetDto)
        {
            if (!IsValidComment(updateRetweetDto.Comment))
            {
                return null;
            }

            var Retweet = _RetweetRepository.GetRetweetById(id);

            if (Retweet == null)
            {
                return null;
            }

            Retweet.UpdateComment(updateRetweetDto.Comment?.Trim() ?? string.Empty);
            Retweet.MarkAsModified();

            _RetweetRepository.UpdateRetweet(Retweet);

            return Retweet.ToDto();
        }

        public bool DeleteRetweet(Guid id)
        {
            var Retweet = _RetweetRepository.GetRetweetById(id);

            if (Retweet == null)
            {
                return false;
            }

            return _RetweetRepository.DeleteRetweet(Retweet);
        }

        private static bool IsValidComment(string? comment)
        {
            return comment == null || comment.Length <= Tweet.MaxContentLength;
        }
    }
}
