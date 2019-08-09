using System.Collections.Generic;
using System.Linq;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            var user = _context
                .Users
                .Include(u => u.UserAchievements)
                .ThenInclude(ua => ua.Achievement)
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
                return null;

            foreach (var ua in user.UserAchievements)
                ua.User = null;

            return user.UserAchievements
                .Select(ua => ua.Achievement)
                .ToList();
        }
    }
}
