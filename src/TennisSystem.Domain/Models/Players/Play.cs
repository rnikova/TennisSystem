using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Players
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

        public Forehand Forehand { get; }

        public Backhand Backhand { get; }
    }
}
