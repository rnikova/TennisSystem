namespace TennisSystem.Domain.Models.Tournaments
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class LocationSpecs
    {
        [Fact]
        public void ValidLocationShouldNotThrowException()
        {
            Action act = () => new Location("Bulgaria", "Sofia");

            act.Should().NotThrow<InvalidTournamentException>();
        }
        
        [Fact]
        public void InvalidCountryShouldThrowException()
        {
            Action act = () => new Location("", "Sofia");

            act.Should().Throw<InvalidTournamentException>();
        }
        
        [Fact]
        public void InvalidCityShouldThrowException()
        {
            Action act = () => new Location("Bulgaria", "");

            act.Should().Throw<InvalidTournamentException>();
        }

    }
}
