using System;
using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class EventRepository : IEventRepository
    {
        public EventRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public int AddEvent(Event eventToAdd)
        {
            if (!IsEventToAddValid(eventToAdd))
                return 0;

            _context.Events.Add(eventToAdd);
            _context.SaveChanges();
            return eventToAdd.Id;
        }
        public Event GetEventById(int eventId)
        {
            return _context.Events.Find(eventId);
        }
        public List<Event> GetTenEventsByCityId(int cityId, int pageNumber)
        {
            var city = _context.Cities.Find(cityId);

            if (city == null)
                return new List<Event>();

            var cityEvents = _context.Events.Where(e => e.Club.City == city);

            return !cityEvents.Any() ?
                new List<Event>() :
                cityEvents.Skip(pageNumber * 10).Take(10).ToList();
        }
        public List<Event> GetTenSimilarEvents(Event mainEvent)
        {
            return _context
                .Events
                .Where(e => e.Club != mainEvent.Club)
                .GroupBy(e => e.Club)
                .Select(e => e.First())
                .ToList();
        }
        public List<Event> GetEventsByClubId(int clubId)
        {
            return _context.Events.Where(e => e.Club.Id == clubId).ToList();
        }
        public bool EditEvent(Event editedEvent)
        {
            if (IsEventValid(editedEvent))
                return false;

            var eventToEdit = _context.Events.Find(editedEvent.Id);
            if (eventToEdit == null)
                return false;

            eventToEdit.Name = editedEvent.Name;
            eventToEdit.Club = editedEvent.Club;
            eventToEdit.StartTime = editedEvent.StartTime;
            eventToEdit.FinishTime = editedEvent.FinishTime;

            _context.SaveChanges();
            return true;
        }
        private bool IsEventNameUnique(Event testEvent) => 
            _context.Events.All(e => e.Name != testEvent.Name.Trim() && e.Id != testEvent.Id);
        private static bool IsEventNameValid(string eventName) => eventName.Trim().Length >= 3;
        private static bool HasEventClub(Club eventClub) => eventClub != null;
        private static bool AreDateTimesValid(DateTime startDate, DateTime finishDate) =>
            startDate > DateTime.Now && startDate > finishDate;
        private static bool HasEventTickets(IEnumerable<Ticket> eventTickets) => eventTickets.Any();
        private bool IsEventValid(Event testEvent) => 
            IsEventNameUnique(testEvent) &&
            IsEventNameValid(testEvent.Name) &&
            HasEventClub(testEvent.Club) &&
            AreDateTimesValid(testEvent.StartTime, testEvent.FinishTime);
        private bool IsEventToAddValid(Event eventToAdd) =>
            IsEventValid(eventToAdd) &&
            HasEventTickets(eventToAdd.Tickets);
    }
}
