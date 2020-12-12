namespace TennisSystem.Domain.Models.Tournaments
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Players;
    using Xunit;

    public class TournamentSpecs
    {
        [Fact]
        public void ValidTournamentShouldNotThrowException()
        {
            Action act = () => A.Dummy<Tournament>();

            act.Should().NotThrow<InvalidTournamentException>();
        }
        
        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Tournament(
                "",
                20000.0m,
                new Location("Bulgaria", "Sofia"),
                new TournamentType(TournamentPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidTournamentException>();
        }
        
        [Fact]
        public void InvalidPrizeShouldThrowException()
        {
            Action act = () => new Tournament(
                "Sofia",
                -1,
                new Location("Bulgaria", "Sofia"),
                new TournamentType(TournamentPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidTournamentException>();
        }

        [Fact]
        public void AddPlayerShoudAddPlayerCorrectly()
        {
            var tournament = A.Dummy<Tournament>();
            var player = A.Dummy<Player>();
            tournament.AddPlayer(player);

            tournament.Players.Count.Should().Be(1);
        }
        
        [Fact]
        public void RemovePlayerShoudRemovePlayerCorrectly()
        {
            var tournament = A.Dummy<Tournament>();
            var player = A.Dummy<Player>();
            tournament.AddPlayer(player);
            tournament.RemovePlayer(player);

            tournament.Players.Count.Should().Be(0);
        }
    }
}
