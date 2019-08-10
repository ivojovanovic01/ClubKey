using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/musicians")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        public MusicianController(IMusicianRepository musicianRepository)
        {
            _musicianRepository = musicianRepository;
        }
        private readonly IMusicianRepository _musicianRepository;
        
        [HttpGet("get-by-event")]
        public IActionResult GetMusicianByEventId(int eventId)
        {
            var musician = _musicianRepository.GetMusicianByEventId(eventId);
            if (musician != null)
                return Ok(musician);
            return Forbid();
        }
    }
}