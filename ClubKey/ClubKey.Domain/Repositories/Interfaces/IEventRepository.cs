using System;
using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IEventRepository
    {
        int AddEvent(Event eventToAdd);
        Event GetEventById(int eventId);
        List<Event> GetTenEventsByCityId(int cityId, int pageNumber);
        List<Event> GetTenSimilarEvents(int eventId);
        List<Event> GetEventsByClubId(int clubId);
        int GetEventsCountByCityId(int cityId);
        Event GetEventByTicketId(Guid ticketId);
        bool EditEvent(Event editedEvent);
    }
}