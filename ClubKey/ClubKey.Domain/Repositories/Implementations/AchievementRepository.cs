using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class AchievementRepository : IAchievementRepository
    {
        public AchievementRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public List<Achievement> GetAllAchievements()
        {
            return _context.Achievements.ToList();
        }
        public List<Achievement> GetAchievementsByUserId(int userId)
        {
            var user = _context.Users.Find(userId);

            return user == null ? new List<Achievement>() : user.UserAchievements.Select(ua => ua.Achievement).ToList();
        }
    }
}
