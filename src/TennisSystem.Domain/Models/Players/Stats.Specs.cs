namespace TennisSystem.Domain.Models.Players
{
    using FluentAssertions;
    using System;
    using TennisSystem.Domain.Exceptions;
    using Xunit;

    public class StatsSpecs
    {
        [Fact]
        public void ValidStatsShouldNotThrowException()
        {
            Action act = () => new Stats(20, 10, 5, 1000);

            act.Should().NotThrow<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidWinsShouldThrowException()
        {
            Action act = () => new Stats(-1, 10, 5, 1000);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidLossShouldThrowException()
        {
            Action act = () => new Stats(20, 56, 5, 1000);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidRankShouldThrowException()
        {
            Action act = () => new Stats(20, 30, 1001, 1000);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void InvalidPointsShouldThrowException()
        {
            Action act = () => new Stats(20, 30, 7, 15001);

            act.Should().Throw<InvalidPlayerException>();
        }
        
        [Fact]
        public void AddTitleShouldAddTitleCorrectly()
        {
            var stats = new Stats(20, 30, 7, 200);

            stats.AddTitle(new Title("valid", 2020));

            stats.Titles.Count.Should().Be(1);
        }
        
        [Fact]
        public void UpdateStatsShouldUpdateDataCorrectly()
        {
            var stats = new Stats(20, 30, 7, 1200);
            stats.Update(1, 0, -2, -200);

            stats.Points.Should().Be(1000);
            stats.Rank.Should().Be(5);
            stats.Loss.Should().Be(30);
            stats.Win.Should().Be(21);
        }
        
        [Fact]
        public void UpdateStatsShouldThrowException()
        {
            var stats = new Stats(20, 30, 7, 1200);
            Action act = () => stats.Update(-1, -1, -2, -200);

            act.Should().Throw<InvalidPlayerException>();
        }
    }
}
