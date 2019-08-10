using System;
using System.Collections.Generic;
using ClubKey.Data.Entities.Models;
using ClubKey.Data.Enums;
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

            var achievements = new List<Achievement>()
            {
                new Achievement()
                {
                    Id = 1,
                    Description = "5 tickets purchased",
                    Name = "bronze medal",
                    RequiredPoints = 5
                },
                new Achievement()
                {
                    Id = 2,
                    Description = "10 tickets purchased",
                    Name = "silver medal",
                    RequiredPoints = 10
                },
                new Achievement()
                {
                    Id = 3,
                    Description = "15 tickets purchased",
                    Name = "gold medal",
                    RequiredPoints = 15
                }
            };

            var splitCity = new City()
            {
                Id = 1,
                Name = "Split"
            };

            var clubs = new List<Club>()
            {
                new Club()
                {
                    Id = 1,
                    Name = "Vanilla",
                    Latitude = 43.521949,
                    Longitude = 16.432046
                },
                new Club()
                {
                    Id = 2,
                    Name = "Zenta",
                    Latitude = 43.500075,
                    Longitude = 16.455708
                },
                new Club()
                {
                    Id = 3,
                    Name = "Moon",
                    Latitude = 43.508144,
                    Longitude = 16.450879
                }
            };

            var musicians = new List<Musician>()
            {
                new Musician()
                {
                    Id = 1,
                    Name = "DJ Krmak"
                },
                new Musician()
                {
                    Id = 2,
                    Name = "DJ Mrki"
                },
                new Musician()
                {
                    Id = 3,
                    Name = "Mate Cajka"
                },
                new Musician()
                {
                    Id = 4,
                    Name = "Severina"
                }
            };

            var events = new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    Name = "Pjena party",
                    Description = "Najbolji party uz puno pjene",
                    Hashtag = EventHashtag.DJ,
                    StartTime = new DateTime(2019, 8, 10, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 11, 3, 00, 00)
                },
                new Event()
                {
                    Id = 2,
                    Name = "White party",
                    Description = "Najbolji party svi u bijelo",
                    Hashtag = EventHashtag.DJ,
                    StartTime = new DateTime(2019, 8, 10, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 11, 5, 00, 00)
                },
                new Event()
                {
                    Id = 3,
                    Name = "Crazy party",
                    Description = "Party iznenađenja",
                    Hashtag = EventHashtag.Rock,
                    StartTime = new DateTime(2019, 8, 10, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 11, 5, 00, 00)
                },
                new Event()
                {
                    Id = 4,
                    Name = "Black party",
                    Description = "Najbolji crni party ikad",
                    Hashtag = EventHashtag.DJ,
                    StartTime = new DateTime(2019, 8, 12, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 13, 3, 00, 00)
                },
                new Event()
                {
                    Id = 5,
                    Name = "Black and white party",
                    Hashtag = EventHashtag.DJ,
                    Description = "Najbolji black and white party u gradu",
                    StartTime = new DateTime(2019, 8, 20, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 21, 3, 00, 00)
                },
                new Event()
                {
                    Id = 6,
                    Name = "Techno party",
                    Description = "Za ljubitelje techna",
                    Hashtag = EventHashtag.Techno,
                    StartTime = new DateTime(2019, 8, 23, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 24, 3, 00, 00)
                },
                new Event()
                {
                    Id = 7,
                    Name = "Pop party",
                    Description = "Najbolji party za ljubitelje popa",
                    Hashtag = EventHashtag.Pop,
                    StartTime = new DateTime(2019, 8, 23, 23, 00, 00),
                    FinishTime = new DateTime(2019, 8, 24, 5, 00, 00)
                },
                new Event()
                {
                    Id = 8,
                    Name = "Rock party",
                    Description = "Najluđi party",
                    Hashtag = EventHashtag.Rock,
                    StartTime = new DateTime(2019, 2, 1, 23, 00, 00),
                    FinishTime = new DateTime(2019, 2, 1, 5, 00, 00)
                }
            };

            var owners = new List<Owner>()
            {
                new Owner()
                {
                    Id = 1,
                    CompanyOib = "12123423323",
                    Username = "zenta01",
                    Password = "Zenta123"
                },
                new Owner()
                {
                    Id = 2,
                    CompanyOib = "23452211236",
                    Username = "moon123",
                    Password = "Moon1"
                },
                new Owner()
                {
                    Id = 3,
                    CompanyOib = "17845342454",
                    Username = "vanilla191",
                    Password = "Vanila12345"
                }
            };

            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "ivanivanic12@gmail.com",
                    FirstName = "Ivan",
                    LastName = "Ivanic",
                    Username = "iivanic12",
                    Password = "Ivanic12",
                    Image = "https://i0.wp.com/www.winhelponline.com/blog/wp-content/uploads/2017/12/user.png?fit=256%2C256&quality=100&ssl=1"
                },
                new User()
                {
                    Id = 2,
                    Email = "matematic1@gmail.com",
                    FirstName = "Mate",
                    LastName = "Matic",
                    Username = "mmatic01",
                    Password = "MMatic01",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png"
                }
            };
            
            var userAchievements = new List<UserAchievement>();

            achievements.ForEach(achievement => users.ForEach(user => userAchievements.Add(new UserAchievement()
            {
                UserPoints = 0,
                AchievementId = achievement.Id,
                UserId = user.Id
            })));

            var tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Id = Guid.Parse("a45bae5b-dae1-4051-99d9-e18d25af4349"),
                    EventId = 1,
                    UserId = 1,
                    Price = 100.00
                },
                new Ticket()
                {
                    Id = Guid.Parse("eaae0a8d-6e00-494c-a9fc-72a316c93780"),
                    EventId = 4,
                    UserId = 1,
                    Price = 100.00
                },
                new Ticket()
                {
                    Id = Guid.Parse("fec6f388-6863-4ded-a03f-89c1d31e5f3d"),
                    EventId = 1,
                    UserId = 2,
                    Price = 100.00
                }
            };

            modelBuilder.Entity<Achievement>().HasData(
                achievements
            );

            modelBuilder.Entity<City>().HasData(
                splitCity
                );

            modelBuilder.Entity<Club>().HasData(
                clubs
            );

            modelBuilder.Entity<Musician>().HasData(
                musicians
            );

            modelBuilder.Entity<Event>().HasData(
                events
            );
            modelBuilder.Entity<Owner>().HasData(
                owners
            );

            modelBuilder.Entity<User>().HasData(
                users
            );
            modelBuilder.Entity<UserAchievement>().HasData(
               userAchievements
            );
            modelBuilder.Entity<Ticket>().HasData(
                tickets
            );
        }
    }
}
