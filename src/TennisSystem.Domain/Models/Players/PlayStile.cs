namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;

    public class PlayStile : ValueObject
    {
        internal PlayStile(
            Forehand forehand,
            Backhand backhand)
        {
            this.Forehand = forehand;
            this.Backhand = backhand;
        }

        private PlayStile()
        {
            this.Forehand = default!;
            this.Backhand = default!;
        }

        public Forehand Forehand { get; }

        public Backhand Backhand { get; }
    }
}
