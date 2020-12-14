namespace TennisSystem.Domain.Models.Players
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class CoachSpecs
    {
        [Fact]
        public void ValidCoachShouldNotThrowException()
        {
            Action act = () => new Coach("Coach");

            act.Should().NotThrow<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidCoachShouldThrowException()
        {
            Action act = () => new Coach("");

            act.Should().Throw<InvalidPlayerException>();
        }
    }
}
