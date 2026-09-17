using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TwitterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("config")]
        public IActionResult GetTweet()
        {
            var con = _configuration.GetValue<string>("Logging:LogLevel:Default");
            return Ok(con);
        }

        [HttpGet]
        public IActionResult GetTweets()
        {
            var maxTweetLength = _configuration.GetValue<int>("TwitterSettings:MaxTweetLength");

            var tweets = new List<Tweet>
            {
                new Tweet(Guid.NewGuid(),"Content"),
                new Tweet(Guid.NewGuid(),"test")
            };

            var returnObject = new
            {
                maxTweetLength,
                tweets
            };

            return Ok(returnObject);

        }
    }
}
