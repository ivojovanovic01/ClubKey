using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class MusicianRepository : IMusicianRepository
    {
        public MusicianRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;

        public Musician GetMusicianByEventId(int eventId)
        {
            var eventById = _context
                .Events
                .Include(e => e.Musician)
                .FirstOrDefault(e => e.Id == eventId);

            return eventById == null ? null : eventById.Musician;
        }
    }
}