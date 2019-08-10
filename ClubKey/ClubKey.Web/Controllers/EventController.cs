using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClubKey.Web.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        private readonly IEventRepository _eventRepository;

        [HttpPost("add")]
        public IActionResult AddEvent(Event eventToAdd)
        {
            var eventId = _eventRepository.AddEvent(eventToAdd);

            if (eventId != 0)
                return Ok(eventId);
            return Forbid();
        }

        [HttpGet("get-by-id")]
        public IActionResult GetEventById(int eventId)
        {
            var eventById = _eventRepository.GetEventById(eventId);
            if (eventById != null)
                return Ok(eventById);
            return Forbid();
        }

        [HttpGet("get-ten-by-city")]
        public IActionResult GetTenEventsByCityId(int cityId, int pageNumber)
        {
            var events = _eventRepository.GetTenEventsByCityId(cityId, pageNumber);
            if (events != null)
                return Ok(events);
            return Forbid();
        }

        [HttpGet("get-ten-similar-events")]
        public IActionResult GetTenSimilarEvents(int eventId)
        {
            var events = _eventRepository.GetTenSimilarEvents(eventId);
            if (events != null)
                return Ok(events);
            return Forbid();
        }

        [HttpGet("get-event-by-club")]
        public IActionResult GetEventsByClubId(int clubId)
        {
            var events = _eventRepository.GetEventsByClubId(clubId);
            if (events != null)
                return Ok(events);
            return Forbid();
        }

        [HttpGet("get-events-count-by-city")]
        public IActionResult GetEventsCountByCityId(int cityId)
        {
            var eventsCount = _eventRepository.GetEventsCountByCityId(cityId);
            return Ok(eventsCount);
        }

        [HttpGet("get-event-by-ticketId")]
        public IActionResult GetEventByTicketId(Guid ticketId)
        {
            var eventToReturn = _eventRepository.GetEventByTicketId(ticketId);
            return Ok(eventToReturn);
        }

        [HttpPost("edit")]
        public IActionResult EditEvent(Event editedEvent)
        {
            var wasEditSuccessful = _eventRepository.EditEvent(editedEvent);
            if (wasEditSuccessful)
                return Ok();
            return Forbid();
        }
    }
}