using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IClubRepository
    {
        List<Club> GetClubsByCityId(int cityId);
        List<Club> GetClubsByOwnerId(int ownerId);
        Club GetClubByEventId(int eventId);
    }
}