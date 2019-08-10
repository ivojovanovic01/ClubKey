using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class CityRepository : ICityRepository
    {
        public CityRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public List<City> GetAllCities()
        {
            return _context.Cities.ToList();
        }
        public City GetCityByClubId(int clubId)
        {
            var city = _context
                .Cities
                .Include(c => c.Clubs)
                .FirstOrDefault(c => c.Clubs.Any(club => club.Id == clubId));

            return city;
        }
    }
}
