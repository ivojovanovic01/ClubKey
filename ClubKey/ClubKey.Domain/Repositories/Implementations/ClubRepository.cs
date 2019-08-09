using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            var city = _context.Cities.Find(cityId);
            return city == null ? null : _context.Clubs.Where(club => club.City == city).ToList();
        }
        public List<Club> GetClubsByOwnerId(int ownerId)
        {
            var owner = _context.Owners.Find(ownerId);
            return owner == null ? null : _context.Clubs.Where(club => club.Owner == owner).ToList();
        }
        public Club GetClubByEventId(int eventId)
        {
            var selectedEvent = _context.Events.Include(e => e.Club).FirstOrDefault(e => e.Id == eventId);
            return selectedEvent == null ? null : _context.Clubs.FirstOrDefault(c => c.Id == selectedEvent.Club.Id);
        }
    }
}
