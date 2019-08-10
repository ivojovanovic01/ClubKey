using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IMusicianRepository
    {
        Musician GetMusicianByEventId(int eventId);
    }
}