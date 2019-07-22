using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class ClubRepository : IClubRepository
    {
        public ClubRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public List<Club> GetClubsByCityId(int cityId)
        {
            return _context.Clubs.Where(club => club.City.Id == cityId).ToList();
        }
        public List<Club> GetClubsByOwnerId(int ownerId)
        {
            return _context.Clubs.Where(club => club.Owner.Id == ownerId).ToList();
        }
    }
}
