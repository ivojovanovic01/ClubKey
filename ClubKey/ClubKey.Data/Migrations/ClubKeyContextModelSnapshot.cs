﻿// <auto-generated />
using System;
using ClubKey.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClubKey.Data.Migrations
{
    [DbContext(typeof(ClubKeyContext))]
    partial class ClubKeyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("RequiredPoints");

                    b.HasKey("Id");

                    b.ToTable("Achievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "5 tickets purchased",
                            Name = "bronze medal",
                            RequiredPoints = 5
                        },
                        new
                        {
                            Id = 2,
                            Description = "10 tickets purchased",
                            Name = "silver medal",
                            RequiredPoints = 10
                        },
                        new
                        {
                            Id = 3,
                            Description = "15 tickets purchased",
                            Name = "gold medal",
                            RequiredPoints = 15
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Split"
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "123123123",
                            Name = "Vanilla"
                        },
                        new
                        {
                            Id = 2,
                            Location = "123123123",
                            Name = "Zenta"
                        },
                        new
                        {
                            Id = 3,
                            Location = "123123123",
                            Name = "Moon"
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId");

                    b.Property<DateTime>("FinishTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FinishTime = new DateTime(2019, 8, 11, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pjena party",
                            StartTime = new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            FinishTime = new DateTime(2019, 8, 11, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "White party",
                            StartTime = new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            FinishTime = new DateTime(2019, 8, 11, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Crazy party",
                            StartTime = new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            FinishTime = new DateTime(2019, 8, 13, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Black party",
                            StartTime = new DateTime(2019, 8, 12, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            FinishTime = new DateTime(2019, 8, 21, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Black and white party",
                            StartTime = new DateTime(2019, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            FinishTime = new DateTime(2019, 8, 24, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Techno party",
                            StartTime = new DateTime(2019, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            FinishTime = new DateTime(2019, 8, 24, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pop party",
                            StartTime = new DateTime(2019, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            FinishTime = new DateTime(2019, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rock party",
                            StartTime = new DateTime(2019, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyOib")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyOib = "12123423323",
                            Password = "Zenta123",
                            Username = "zenta01"
                        },
                        new
                        {
                            Id = 2,
                            CompanyOib = "23452211236",
                            Password = "Moon1",
                            Username = "moon123"
                        },
                        new
                        {
                            Id = 3,
                            CompanyOib = "17845342454",
                            Password = "Vanila12345",
                            Username = "vanilla191"
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<double>("Price");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a45bae5b-dae1-4051-99d9-e18d25af4349"),
                            EventId = 1,
                            Price = 100.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = new Guid("eaae0a8d-6e00-494c-a9fc-72a316c93780"),
                            EventId = 4,
                            Price = 100.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = new Guid("fec6f388-6863-4ded-a03f-89c1d31e5f3d"),
                            EventId = 1,
                            Price = 100.0,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ivanivanic12@gmail.com",
                            FirstName = "Ivan",
                            Image = "https://i0.wp.com/www.winhelponline.com/blog/wp-content/uploads/2017/12/user.png?fit=256%2C256&quality=100&ssl=1",
                            LastName = "Ivanic",
                            Password = "Ivanic12",
                            Username = "iivanic12"
                        },
                        new
                        {
                            Id = 2,
                            Email = "matematic1@gmail.com",
                            FirstName = "Mate",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png",
                            LastName = "Matic",
                            Password = "MMatic01",
                            Username = "mmatic01"
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.UserAchievement", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("AchievementId");

                    b.Property<int>("UserPoints");

                    b.HasKey("UserId", "AchievementId");

                    b.HasIndex("AchievementId");

                    b.ToTable("UserAchievements");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AchievementId = 1,
                            UserPoints = 0
                        },
                        new
                        {
                            UserId = 2,
                            AchievementId = 1,
                            UserPoints = 0
                        },
                        new
                        {
                            UserId = 1,
                            AchievementId = 2,
                            UserPoints = 0
                        },
                        new
                        {
                            UserId = 2,
                            AchievementId = 2,
                            UserPoints = 0
                        },
                        new
                        {
                            UserId = 1,
                            AchievementId = 3,
                            UserPoints = 0
                        },
                        new
                        {
                            UserId = 2,
                            AchievementId = 3,
                            UserPoints = 0
                        });
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Club", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.City", "City")
                        .WithMany("Clubs")
                        .HasForeignKey("CityId");

                    b.HasOne("ClubKey.Data.Entities.Models.Owner", "Owner")
                        .WithMany("Clubs")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Event", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Ticket", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubKey.Data.Entities.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.UserAchievement", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.Achievement", "Achievement")
                        .WithMany("UserAchievements")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubKey.Data.Entities.Models.User", "User")
                        .WithMany("UserAchievements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
