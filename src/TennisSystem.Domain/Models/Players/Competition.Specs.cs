namespace TennisSystem.Domain.Models.Players
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class CompetitionSpecs
    {
        [Fact]
        public void ValidTournamentShouldNotThrowException()
        {
            Action act = () => A.Dummy<Competition>();

            act.Should().NotThrow<InvalidPlayerException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Competition(
                "",
                20000.0m,
                new CompetitionType(CompetitionPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidPlayerException>();
        }

        [Fact]
        public void InvalidPrizeShouldThrowException()
        {
            Action act = () => new Competition(
                "Sofia",
                -1,
                new CompetitionType(CompetitionPoints.t250,
                Surface.Hard,
                Event.ATP));

            act.Should().Throw<InvalidPlayerException>();
        }  
    }
}
