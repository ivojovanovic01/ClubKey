using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        private readonly IUserRepository _userRepository;

        [HttpPost("add")]
        public IActionResult AddUser(User userToAdd)
        {
            var user = _userRepository.AddUser(userToAdd);

            if (user != 0)
                return Ok(user);
            return Forbid();
        }

        [HttpGet("get-by-username")]
        public IActionResult GetUserByUsername(string username)
        {
            var user = _userRepository.GetUserByUsername(username);

            if (user != null)
                return Ok(user);
            return Forbid();
        }
    }
}