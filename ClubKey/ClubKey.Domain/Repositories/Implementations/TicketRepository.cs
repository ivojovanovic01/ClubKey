using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class TicketRepository : ITicketRepository
    {
        public TicketRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public List<Ticket> GetTicketsByUserId(int userId)
        {
            var user = _context.Users.Find(userId);
            return user == null ? null :_context.Tickets.Where(ticket => ticket.UserId == userId).ToList();
        }
    }
}
