namespace TennisSystem.Domain.Models.Statistics
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class PlayerSpecs 
    {
        [Fact]
        public void ValidPlayerShouldNotThrowException()
        {
            Action act = () => A.Dummy<Player>();

            act.Should().NotThrow<InvalidStatisticException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Player("", 10, 9, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidAcesShouldThrowException()
        {
            Action act = () => new Player("Name", -1, 9, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidDoubleFaultsShouldThrowException()
        {
            Action act = () => new Player("Name", 10, -1, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidBreakPointsShouldThrowException()
        {
            Action act = () => new Player("Name", 10, 9, -1);

            act.Should().Throw<InvalidStatisticException>();
        }
    }
}
