using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        private readonly ICityRepository _cityRepository;

        [HttpGet("all")]
        public IActionResult GetAllCities()
        {
            var cities = _cityRepository.GetAllCities();
            return Ok(cities);
        }

        [HttpGet("get-by-club")]
        public IActionResult GetCityByClubId(int clubId)
        {
            var city = _cityRepository.GetCityByClubId(clubId);
            if (city != null)
                return Ok(city);
            return Forbid();
        }
    }
}