using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10Test
    {
        public void Run()
        {
            Tweet likeableTweet = new Tweet(Guid.NewGuid(), "This is another tweet!");

            Console.WriteLine(likeableTweet.CanBeLiked());

            var maxTweetLength = 200;
        }
    }
}
