namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;

    public class CompetitionType : ValueObject
    {
        internal CompetitionType(
            CompetitionPoints tournamentPoints,
            Surface surface,
            Event @event)
        {
            this.TournamentPoints = tournamentPoints;
            this.Surface = surface;
            this.Event = @event;
        }

        public CompetitionPoints TournamentPoints { get; }

        public Surface Surface { get; }

        public Event Event { get; }
    }
}
