using Microsoft.AspNetCore.Mvc;
using SmallBasket.API.Model;
using SmallBasket.API.Repository;

namespace SmallBasket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(usersRepository));
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(Users_RM user)
        {
            return Ok(await usersRepository.CreateUser(user));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login_RM login)
        {
            return Ok(await usersRepository.Login(login));
        }
    }
}
