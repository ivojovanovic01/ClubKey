
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class UserAchievement
    {
        public UserAchievement()
        {
        }
        public UserAchievement(User user, Achievement achievement)
        {
            User = user;
            UserId = user.Id;
            Achievement = achievement;
            AchievementId = achievement.Id;
        }
        public int UserId { get; set; }
        public User User { get; set; }

        public int AchievementId { get; set; }
        public Achievement Achievement { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int UserPoints { get; set; }
    }
}
