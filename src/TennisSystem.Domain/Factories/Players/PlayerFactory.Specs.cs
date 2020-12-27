namespace TennisSystem.Domain.Factories.Players
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Players;
    using Xunit;

    public class PlayerFactorySpecs
    {
        [Fact]
        public void BuildShouldThrowExceptionIfCharacteristicsIsNotSet()
        {
            var playerFactory = new PlayerFactory();

            Action act = () => playerFactory
                .WithName("Player Name")
                .WithCoach("coach name")
                .WithStats(10, 20, 33, 2000)
                .Build();

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void BuildShouldThrowExceptionIfCoachIsNotSet()
        {
            var playerFactory = new PlayerFactory();

            Action act = () => playerFactory
                .WithName("Player Name")
                .WithCharacteristics(19, "Country", 60.2, 183.2, new Play(Forehand.LeftHanded, Backhand.OneHanded))
                .WithStats(10, 20, 33, 2000)
                .Build();

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void BuildShouldThrowExceptionIfStatsIsNotSet()
        {
            var playerFactory = new PlayerFactory();

            Action act = () => playerFactory
                .WithName("Player Name")
                .WithCharacteristics(19, "Country", 60.2, 183.2, new Play(Forehand.LeftHanded, Backhand.OneHanded))
                .WithCoach("Coach")
                .Build();

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void BuildShouldCreatePLayerIfEveryPropertyIsSet()
        {
            var playerFactory = new PlayerFactory();

            var player = playerFactory
                .WithName("Player Name")
                .WithCharacteristics(19, "Country", 60.2, 183.2, new Play(Forehand.LeftHanded, Backhand.OneHanded))
                .WithCoach("Coach")
                .WithStats(10, 20, 17, 2200)
                .Build();

            player.Should().NotBeNull();
        }
    }
}
