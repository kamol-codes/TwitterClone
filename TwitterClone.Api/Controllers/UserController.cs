using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]
        public IActionResult GetUsers()
        {

            var users = new List<User>
            {

                new User
                {
                    Email = "aragorn.elessar@gmail.com",
                    Username = "aragorn",
                    FirstName = "Aragorn",
                    LastName = "Elessar"
                },
                new User
                {
                    Email = "legolas.greenleaf@gmail.com",
                    Username = "legolas",
                    FirstName = "Legolas",
                    LastName = "Greenleaf"
                },
                new User
                {
                    Email = "gimli.gloin@gmail.com",
                    Username = "gimli",
                    FirstName = "Gimli",
                    LastName = "Gloin"
                }
            };

            return Ok(users);
        }
    }
}