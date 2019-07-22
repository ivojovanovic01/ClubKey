using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/clubs")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        private readonly IClubRepository _clubRepository;

        [HttpGet("get-by-city")]
        public IActionResult GetClubsByCityId(int cityId)
        {
            var clubs = _clubRepository.GetClubsByCityId(cityId);
            if(clubs != null)
                return Ok(clubs);
            return Forbid();
        }

        [HttpGet("get-by-owner")]
        public IActionResult GetClubsByOwnerId(int ownerId)
        {
            var clubs = _clubRepository.GetClubsByOwnerId(ownerId);
            if (clubs != null)
                return Ok(clubs);
            return Forbid();
        }
    }
}