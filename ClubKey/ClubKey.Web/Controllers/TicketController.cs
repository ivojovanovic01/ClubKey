using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClubKey.Web.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        private readonly ITicketRepository _ticketRepository;

        [HttpGet("get-by-user")]
        public IActionResult GetTicketsByUserId(int userId)
        {
            var tickets = _ticketRepository.GetTicketsByUserId(userId);

            if (tickets != null)
                return Ok(tickets);
            return Forbid();
        }

        [HttpPost("add")]
        public IActionResult AddTicket(Ticket ticketToAdd)
        {
            var isTicketCreated = _ticketRepository.AddTicket(ticketToAdd);

            if (isTicketCreated)
                return Ok();
            return Forbid();
        }
    }
}