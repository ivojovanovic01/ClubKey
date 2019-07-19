using ClubKey.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubKey.Data.Entities
{
    public class ClubKeyContext : DbContext
    {
        public ClubKeyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAchievement>()
                .HasKey(ua => new {ua.UserId, ua.AchievementId});

            modelBuilder.Entity<UserAchievement>()
                .HasOne(ua => ua.User)
                .WithMany(u => u.UserAchievements)
                .HasForeignKey(ua => ua.UserId);

            modelBuilder.Entity<UserAchievement>()
                .HasOne(ua => ua.Achievement)
                .WithMany(u => u.UserAchievements)
                .HasForeignKey(ua => ua.AchievementId);
        }
    }
}
