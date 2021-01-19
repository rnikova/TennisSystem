namespace TennisSystem.Domain.Models.Players
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

            act.Should().NotThrow<InvalidPlayerException>();
        }

        [Fact]
        public void InvalidNameShouldThrowException()
        {
            Action act = () => new Player(
                "",
                new Coach("Coach"),
                new Characteristics(
                    22,
                    "Bulgaria",
                    70,
                    177.0,
                    new PlayStile(Forehand.LeftHanded, Backhand.OneHanded)),
                new Stats(20, 10, 4, 3000));

            act.Should().Throw<InvalidPlayerException>();
        }
    }
}
