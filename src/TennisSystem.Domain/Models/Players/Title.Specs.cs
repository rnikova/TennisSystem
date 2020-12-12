namespace TennisSystem.Domain.Models.Players
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class TitleSpecs
    {
        [Fact]
        public void ValidTitleShouldNotThrowException()
        {
            Action act = () => new Title("Sofia open", 2020);

            act.Should().NotThrow<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidTournamentShouldThrowException()
        {
            Action act = () => new Title("", 2020);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidYearShouldThrowException()
        {
            Action act = () => new Title("Sofia open", 1899);

            act.Should().Throw<InvalidTournamentException>();
        }
    }
}
