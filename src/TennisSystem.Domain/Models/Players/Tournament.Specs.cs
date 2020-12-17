namespace TennisSystem.Domain.Models.Players
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class TournamentSpecs
    {
        [Fact]
        public void ValidTournamentShouldNotThrowException()
        {
            Action act = () => A.Dummy<Tournament>();

            act.Should().NotThrow<InvalidPlayerException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Tournament(
                "",
                20000.0m,
                new TournamentType(TournamentPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidPlayerException>();
        }

        [Fact]
        public void InvalidPrizeShouldThrowException()
        {
            Action act = () => new Tournament(
                "Sofia",
                -1,
                new TournamentType(TournamentPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidPlayerException>();
        }  
    }
}
