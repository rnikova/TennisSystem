﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisSystem.Infrastructure.Persistence;

namespace TennisSystem.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(TennisSystemDbContext))]
    [Migration("20201223214929_InitialDomainTables")]
    partial class InitialDomainTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Prize")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Statistics.Participator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Aces")
                        .HasColumnType("int");

                    b.Property<int>("BreakPoints")
                        .HasColumnType("int");

                    b.Property<int>("DoubleFaults")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("StatisticId")
                        .HasColumnType("int");

                    b.Property<int?>("StatisticId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatisticId");

                    b.HasIndex("StatisticId1");

                    b.ToTable("Participators");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Statistics.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FirstPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstPlayerId");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("TournamentId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("Prize")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Competition", b =>
                {
                    b.HasOne("TennisSystem.Domain.Models.Players.Player", null)
                        .WithMany("Competitions")
                        .HasForeignKey("PlayerId");

                    b.OwnsOne("TennisSystem.Domain.Models.Players.CompetitionType", "CompetitionType", b1 =>
                        {
                            b1.Property<int>("CompetitionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.HasKey("CompetitionId");

                            b1.ToTable("Competitions");

                            b1.WithOwner()
                                .HasForeignKey("CompetitionId");

                            b1.OwnsOne("TennisSystem.Domain.Models.Players.CompetitionPoints", "CompetitionPoints", b2 =>
                                {
                                    b2.Property<int>("CompetitionTypeCompetitionId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("CompetitionTypeCompetitionId");

                                    b2.ToTable("Competitions");

                                    b2.WithOwner()
                                        .HasForeignKey("CompetitionTypeCompetitionId");
                                });

                            b1.OwnsOne("TennisSystem.Domain.Models.Players.Event", "Event", b2 =>
                                {
                                    b2.Property<int>("CompetitionTypeCompetitionId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("CompetitionTypeCompetitionId");

                                    b2.ToTable("Competitions");

                                    b2.WithOwner()
                                        .HasForeignKey("CompetitionTypeCompetitionId");
                                });

                            b1.OwnsOne("TennisSystem.Domain.Models.Players.Surface", "Surface", b2 =>
                                {
                                    b2.Property<int>("CompetitionTypeCompetitionId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("CompetitionTypeCompetitionId");

                                    b2.ToTable("Competitions");

                                    b2.WithOwner()
                                        .HasForeignKey("CompetitionTypeCompetitionId");
                                });

                            b1.Navigation("CompetitionPoints")
                                .IsRequired();

                            b1.Navigation("Event")
                                .IsRequired();

                            b1.Navigation("Surface")
                                .IsRequired();
                        });

                    b.Navigation("CompetitionType")
                        .IsRequired();
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Player", b =>
                {
                    b.HasOne("TennisSystem.Domain.Models.Players.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("TennisSystem.Domain.Models.Players.Characteristics", "Characteristics", b1 =>
                        {
                            b1.Property<int>("PlayerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Age")
                                .HasColumnType("int");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Height")
                                .HasColumnType("float");

                            b1.Property<double>("Weight")
                                .HasColumnType("float");

                            b1.HasKey("PlayerId");

                            b1.ToTable("Players");

                            b1.WithOwner()
                                .HasForeignKey("PlayerId");

                            b1.OwnsOne("TennisSystem.Domain.Models.Players.Play", "Play", b2 =>
                                {
                                    b2.Property<int>("CharacteristicsPlayerId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.HasKey("CharacteristicsPlayerId");

                                    b2.ToTable("Players");

                                    b2.WithOwner()
                                        .HasForeignKey("CharacteristicsPlayerId");

                                    b2.OwnsOne("TennisSystem.Domain.Models.Players.Backhand", "Backhand", b3 =>
                                        {
                                            b3.Property<int>("PlayCharacteristicsPlayerId")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int")
                                                .UseIdentityColumn();

                                            b3.Property<int>("Value")
                                                .HasColumnType("int");

                                            b3.HasKey("PlayCharacteristicsPlayerId");

                                            b3.ToTable("Players");

                                            b3.WithOwner()
                                                .HasForeignKey("PlayCharacteristicsPlayerId");
                                        });

                                    b2.OwnsOne("TennisSystem.Domain.Models.Players.Forehand", "Forehand", b3 =>
                                        {
                                            b3.Property<int>("PlayCharacteristicsPlayerId")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int")
                                                .UseIdentityColumn();

                                            b3.Property<int>("Value")
                                                .HasColumnType("int");

                                            b3.HasKey("PlayCharacteristicsPlayerId");

                                            b3.ToTable("Players");

                                            b3.WithOwner()
                                                .HasForeignKey("PlayCharacteristicsPlayerId");
                                        });

                                    b2.Navigation("Backhand")
                                        .IsRequired();

                                    b2.Navigation("Forehand")
                                        .IsRequired();
                                });

                            b1.Navigation("Play")
                                .IsRequired();
                        });

                    b.OwnsOne("TennisSystem.Domain.Models.Players.Stats", "Stats", b1 =>
                        {
                            b1.Property<int>("PlayerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Loss")
                                .HasColumnType("int");

                            b1.Property<int>("Points")
                                .HasColumnType("int");

                            b1.Property<int>("Rank")
                                .HasColumnType("int");

                            b1.Property<int>("Win")
                                .HasColumnType("int");

                            b1.HasKey("PlayerId");

                            b1.ToTable("Players");

                            b1.WithOwner()
                                .HasForeignKey("PlayerId");

                            b1.OwnsMany("TennisSystem.Domain.Models.Players.Title", "Titles", b2 =>
                                {
                                    b2.Property<int>("StatsPlayerId")
                                        .HasColumnType("int");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.HasKey("StatsPlayerId", "Id");

                                    b2.ToTable("Title");

                                    b2.WithOwner()
                                        .HasForeignKey("StatsPlayerId");
                                });

                            b1.Navigation("Titles");
                        });

                    b.Navigation("Characteristics")
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Stats")
                        .IsRequired();
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Statistics.Participator", b =>
                {
                    b.HasOne("TennisSystem.Domain.Models.Statistics.Statistic", null)
                        .WithMany("Men")
                        .HasForeignKey("StatisticId");

                    b.HasOne("TennisSystem.Domain.Models.Statistics.Statistic", null)
                        .WithMany("Women")
                        .HasForeignKey("StatisticId1");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Match", b =>
                {
                    b.HasOne("TennisSystem.Domain.Models.Tournaments.Participant", "FirstPlayer")
                        .WithMany()
                        .HasForeignKey("FirstPlayerId");

                    b.HasOne("TennisSystem.Domain.Models.Tournaments.Participant", "SecondPlayer")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TennisSystem.Domain.Models.Tournaments.Tournament", null)
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId");

                    b.OwnsMany("TennisSystem.Domain.Models.Tournaments.Set", "Result", b1 =>
                        {
                            b1.Property<int>("MatchId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("FirstParticipantPoints")
                                .HasColumnType("int");

                            b1.Property<int>("SecondParticipantPoints")
                                .HasColumnType("int");

                            b1.HasKey("MatchId", "Id");

                            b1.ToTable("Set");

                            b1.WithOwner()
                                .HasForeignKey("MatchId");
                        });

                    b.Navigation("FirstPlayer");

                    b.Navigation("Result");

                    b.Navigation("SecondPlayer");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Participant", b =>
                {
                    b.OwnsOne("TennisSystem.Domain.Models.Tournaments.Characteristics", "Characteristics", b1 =>
                        {
                            b1.Property<int>("ParticipantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Age")
                                .HasColumnType("int");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Height")
                                .HasColumnType("float");

                            b1.Property<double>("Weight")
                                .HasColumnType("float");

                            b1.HasKey("ParticipantId");

                            b1.ToTable("Participants");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantId");

                            b1.OwnsOne("TennisSystem.Domain.Models.Tournaments.Play", "Play", b2 =>
                                {
                                    b2.Property<int>("CharacteristicsParticipantId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.HasKey("CharacteristicsParticipantId");

                                    b2.ToTable("Participants");

                                    b2.WithOwner()
                                        .HasForeignKey("CharacteristicsParticipantId");

                                    b2.OwnsOne("TennisSystem.Domain.Models.Tournaments.Backhand", "Backhand", b3 =>
                                        {
                                            b3.Property<int>("PlayCharacteristicsParticipantId")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int")
                                                .UseIdentityColumn();

                                            b3.Property<int>("Value")
                                                .HasColumnType("int");

                                            b3.HasKey("PlayCharacteristicsParticipantId");

                                            b3.ToTable("Participants");

                                            b3.WithOwner()
                                                .HasForeignKey("PlayCharacteristicsParticipantId");
                                        });

                                    b2.OwnsOne("TennisSystem.Domain.Models.Tournaments.Forehand", "Forehand", b3 =>
                                        {
                                            b3.Property<int>("PlayCharacteristicsParticipantId")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int")
                                                .UseIdentityColumn();

                                            b3.Property<int>("Value")
                                                .HasColumnType("int");

                                            b3.HasKey("PlayCharacteristicsParticipantId");

                                            b3.ToTable("Participants");

                                            b3.WithOwner()
                                                .HasForeignKey("PlayCharacteristicsParticipantId");
                                        });

                                    b2.Navigation("Backhand")
                                        .IsRequired();

                                    b2.Navigation("Forehand")
                                        .IsRequired();
                                });

                            b1.Navigation("Play")
                                .IsRequired();
                        });

                    b.OwnsOne("TennisSystem.Domain.Models.Tournaments.Stats", "Stats", b1 =>
                        {
                            b1.Property<int>("ParticipantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Loss")
                                .HasColumnType("int");

                            b1.Property<int>("Rank")
                                .HasColumnType("int");

                            b1.Property<int>("Win")
                                .HasColumnType("int");

                            b1.HasKey("ParticipantId");

                            b1.ToTable("Participants");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantId");
                        });

                    b.Navigation("Characteristics")
                        .IsRequired();

                    b.Navigation("Stats")
                        .IsRequired();
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Tournament", b =>
                {
                    b.OwnsOne("TennisSystem.Domain.Models.Tournaments.Location", "Location", b1 =>
                        {
                            b1.Property<int>("TournamentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TournamentId");

                            b1.ToTable("Tournaments");

                            b1.WithOwner()
                                .HasForeignKey("TournamentId");
                        });

                    b.OwnsOne("TennisSystem.Domain.Models.Tournaments.TournamentType", "TournamentType", b1 =>
                        {
                            b1.Property<int>("TournamentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.HasKey("TournamentId");

                            b1.ToTable("Tournaments");

                            b1.WithOwner()
                                .HasForeignKey("TournamentId");

                            b1.OwnsOne("TennisSystem.Domain.Models.Tournaments.Event", "Event", b2 =>
                                {
                                    b2.Property<int>("TournamentTypeTournamentId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("TournamentTypeTournamentId");

                                    b2.ToTable("Tournaments");

                                    b2.WithOwner()
                                        .HasForeignKey("TournamentTypeTournamentId");
                                });

                            b1.OwnsOne("TennisSystem.Domain.Models.Tournaments.Surface", "Surface", b2 =>
                                {
                                    b2.Property<int>("TournamentTypeTournamentId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("TournamentTypeTournamentId");

                                    b2.ToTable("Tournaments");

                                    b2.WithOwner()
                                        .HasForeignKey("TournamentTypeTournamentId");
                                });

                            b1.OwnsOne("TennisSystem.Domain.Models.Tournaments.TournamentPoints", "TournamentPoints", b2 =>
                                {
                                    b2.Property<int>("TournamentTypeTournamentId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .UseIdentityColumn();

                                    b2.Property<int>("Value")
                                        .HasColumnType("int");

                                    b2.HasKey("TournamentTypeTournamentId");

                                    b2.ToTable("Tournaments");

                                    b2.WithOwner()
                                        .HasForeignKey("TournamentTypeTournamentId");
                                });

                            b1.Navigation("Event")
                                .IsRequired();

                            b1.Navigation("Surface")
                                .IsRequired();

                            b1.Navigation("TournamentPoints")
                                .IsRequired();
                        });

                    b.Navigation("Location")
                        .IsRequired();

                    b.Navigation("TournamentType")
                        .IsRequired();
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Players.Player", b =>
                {
                    b.Navigation("Competitions");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Statistics.Statistic", b =>
                {
                    b.Navigation("Men");

                    b.Navigation("Women");
                });

            modelBuilder.Entity("TennisSystem.Domain.Models.Tournaments.Tournament", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
