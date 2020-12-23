namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.MatchResult;

    public class Set : ValueObject
    {
        internal Set(
            int firstParticipantPoints,
            int secondPartisipantPoints)
        {
            this.Validate(firstParticipantPoints, secondPartisipantPoints);

            this.FirstParticipantPoints = firstParticipantPoints;
            this.SecondParticipantPoints = secondPartisipantPoints;
        }

        private Set()
        {
            this.FirstParticipantPoints = default!;
            this.SecondParticipantPoints = default!;
        }

        public int FirstParticipantPoints { get; set; }

        public int SecondParticipantPoints { get; set; }

        private void Validate(int firstParticipantPoints, int secondPartisipantPoints)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                firstParticipantPoints,
                MinPoints,
                MaxPoints,
                nameof(this.FirstParticipantPoints));
            
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                secondPartisipantPoints,
                MinPoints,
                MaxPoints,
                nameof(this.SecondParticipantPoints));
        }
    }
}
