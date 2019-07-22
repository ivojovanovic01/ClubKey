using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class OwnerRepository : IOwnerRepository
    {
        public OwnerRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public Owner GetOwnerByUsername(string ownerUsername)
        {
            return _context.Owners.FirstOrDefault(owner => owner.Username == ownerUsername);
        }
    }
}
