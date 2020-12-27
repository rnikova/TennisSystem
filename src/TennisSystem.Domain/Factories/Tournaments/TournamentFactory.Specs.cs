namespace TennisSystem.Domain.Factories.Tournaments
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Tournaments;
    using Xunit;

    public class TournamentFactorySpecs
    {
        [Fact]
        public void BuildShouldThrowExceptionIfLocationIsNotSet()
        {
            var tournamentFactory = new TournamentFactory();

            Action act = () => tournamentFactory
                .WithName("Tournament Name")
                .WithPrize(20332.3m)
                .WithTournamentType(TournamentPoints.t250, Surface.Hard, Event.ATP)
                .Build();

            act.Should().Throw<InvalidTournamentException>();
        }

        [Fact]
        public void BuildShouldThrowExceptionIfTournamentTypeIsNotSet()
        {
            var tournamentFactory = new TournamentFactory();

            Action act = () => tournamentFactory
                .WithName("Tournament Name")
                .WithPrize(20332.3m)
                .WithLocation("country", "city")
                .Build();

            act.Should().Throw<InvalidTournamentException>();
        }

        [Fact]
        public void BuildShouldCreateTournamentIfEveryPropertyIsSet()
        {
            var tournamentFactory = new TournamentFactory();

            var tournament = tournamentFactory
                .WithName("Player Name")
                .WithPrize(2345.2m)
                .WithLocation("country", "city")
                .WithTournamentType(TournamentPoints.t250, Surface.Hard, Event.ATP)
                .Build();

            tournament.Should().NotBeNull();
        }
    }
}
