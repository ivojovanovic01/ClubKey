
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class UserAchievement
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int AchievementId { get; set; }
        public Achievement Achievement { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int UserPoints { get; set; }
    }
}
