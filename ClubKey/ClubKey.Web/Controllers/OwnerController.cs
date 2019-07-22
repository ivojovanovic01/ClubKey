using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/owners")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        public OwnerController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        private readonly IOwnerRepository _ownerRepository;

        [HttpGet("add")]
        public IActionResult GetOwnerByUsername(string ownerUsername)
        {
            var owner = _ownerRepository.GetOwnerByUsername(ownerUsername);

            if (owner != null)
                return Ok(owner);
            return Forbid();
        }
    }
}