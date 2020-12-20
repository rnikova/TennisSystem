namespace TennisSystem.Domain.Models.Statistics
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class ParticipatorSpecs 
    {
        [Fact]
        public void ValidPlayerShouldNotThrowException()
        {
            Action act = () => A.Dummy<Participator>();

            act.Should().NotThrow<InvalidStatisticException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Participator("", 10, 9, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidAcesShouldThrowException()
        {
            Action act = () => new Participator("Name", -1, 9, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidDoubleFaultsShouldThrowException()
        {
            Action act = () => new Participator("Name", 10, -1, 6);

            act.Should().Throw<InvalidStatisticException>();
        }
        
        [Fact]
        public void InvalidBreakPointsShouldThrowException()
        {
            Action act = () => new Participator("Name", 10, 9, -1);

            act.Should().Throw<InvalidStatisticException>();
        }
    }
}
