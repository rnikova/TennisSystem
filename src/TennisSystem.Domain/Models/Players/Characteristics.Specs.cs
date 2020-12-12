namespace TennisSystem.Domain.Models.Players
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class CharacteristicsSpecs
    {
        [Fact]
        public void ValidCharacteristicsShouldNotThrowException()
        {
            var play = new Play(Forehand.RightHanded, Backhand.TwoHanded);

            Action act = () => new Characteristics(20, "Bulgaria", 70, 175.0, play);

            act.Should().NotThrow<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidAgeShouldThrowException()
        {
            var play = new Play(Forehand.RightHanded, Backhand.TwoHanded);

            Action act = () => new Characteristics(7, "Bulgaria", 70, 175.0, play);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidCountryShouldThrowException()
        {
            var play = new Play(Forehand.RightHanded, Backhand.TwoHanded);

            Action act = () => new Characteristics(20, "", 70, 175.0, play);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidWeightShouldThrowException()
        {
            var play = new Play(Forehand.RightHanded, Backhand.TwoHanded);

            Action act = () => new Characteristics(20, "Bulgaria", 101, 175.0, play);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidHeightShouldThrowException()
        {
            var play = new Play(Forehand.RightHanded, Backhand.TwoHanded);

            Action act = () => new Characteristics(20, "Bulgaria", 70, 135.0, play);

            act.Should().Throw<InvalidPlayerException>();
        }
        
    }
}
