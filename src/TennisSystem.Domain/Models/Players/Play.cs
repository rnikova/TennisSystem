namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;

    public class Play : ValueObject
    {
        internal Play(
            Forehand forehand,
            Backhand backhand)
        {
            this.Forehand = forehand;
            this.Backhand = backhand;
        }

        public Forehand Forehand { get; }

        public Backhand Backhand { get; }
    }
}
