using Microsoft.AspNetCore.Mvc;
using TallerCodeChallenge.Interface;
using TallerCodeChallenge.Models;

namespace TallerCodeChallenge.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUsername(string username)
        {

            var user = await _userRepository.GetByUsername(username);

            if (user == null) return NotFound("User not found");

            return Ok($"Hello, {user.Name}");
        }
    }
}
