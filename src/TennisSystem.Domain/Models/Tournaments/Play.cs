using TennisSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Play : ValueObject
    {
        internal Play(
            Forehand forehand,
            Backhand backhand)
        {
            this.Forehand = forehand;
            this.Backhand = backhand;
        }

        private Play()
        {
            this.Backhand = default!;
            this.Forehand = default!;
        }

        public Forehand Forehand { get; }

        public Backhand Backhand { get; }
    }
}
