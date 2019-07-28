using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/achievements")]
    [ApiController]
    public class AchievementController : ControllerBase
    {
        public AchievementController(IAchievementRepository achievementRepository)
        {
            _achievementRepository = achievementRepository;
        }
        private readonly IAchievementRepository _achievementRepository;

        [HttpGet("all")]
        public IActionResult GetAllAchievements()
        {
            var achievements = _achievementRepository.GetAllAchievements();
            return Ok(achievements);
        }

        [HttpGet("get-by-id")]
        public IActionResult GetAchievementsByUserId(int userId)
        {
            var achievements = _achievementRepository.GetAchievementsByUserId(userId);
            if(achievements != null)
                return Ok(achievements);
            return Forbid();
        }
    }
}