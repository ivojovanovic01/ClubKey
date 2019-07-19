using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IEventRepository
    {
        int AddEvent(Event eventToAdd);
        List<Event> GetTenEventsByCityId(int cityId);
        List<Event> GetTenSimilarEvents(Event mainEvent);
        List<Event> GetEventsByClubId(int clubId);
        Event GetEventById(int eventId);
        bool EditEvent(Event editedEvent);
    }
}