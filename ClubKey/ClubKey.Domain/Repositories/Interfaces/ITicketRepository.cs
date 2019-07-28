using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        List<Ticket> GetTicketsByUserId(int userId);
    }
}