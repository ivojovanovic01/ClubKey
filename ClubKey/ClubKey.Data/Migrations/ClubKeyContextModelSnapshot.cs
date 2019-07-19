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
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId");

                    b.Property<DateTime>("FinishTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Events");
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
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.UserAchievement", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("AchievementId");

                    b.Property<int>("UserPoints");

                    b.HasKey("UserId", "AchievementId");

                    b.HasIndex("AchievementId");

                    b.ToTable("UserAchievements");
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Club", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.City", "City")
                        .WithMany("Clubs")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubKey.Data.Entities.Models.Owner", "Owner")
                        .WithMany("Clubs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubKey.Data.Entities.Models.Event", b =>
                {
                    b.HasOne("ClubKey.Data.Entities.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
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
