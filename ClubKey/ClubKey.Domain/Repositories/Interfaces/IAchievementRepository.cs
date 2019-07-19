using System.Collections.Generic;
using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IAchievementRepository
    {
        List<Achievement> GetAllAchievements();
        List<Achievement> GetAchievementsByUserId(int userId);
    }
}