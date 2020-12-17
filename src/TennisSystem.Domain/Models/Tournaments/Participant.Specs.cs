namespace TennisSystem.Domain.Models.Tournaments
{
    using FakeItEasy;
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class ParticipantSpecs
    {
        [Fact]
        public void ValidParticipantShouldNotThrowException()
        {
            Action act = () => A.Dummy<Participant>();

            act.Should().NotThrow<InvalidTournamentException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Participant(
                "",
                new Characteristics(
                    22,
                    "Bulgaria",
                    70,
                    177.0,
                    new Play(Forehand.LeftHanded, Backhand.OneHanded)),
                new Stats(20, 10, 4));

            act.Should().Throw<InvalidTournamentException>();
        }
    }
}
