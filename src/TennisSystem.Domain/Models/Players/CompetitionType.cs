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
            this.CompetitionPoints = tournamentPoints;
            this.Surface = surface;
            this.Event = @event;
        }

        private CompetitionType()
        {
            this.CompetitionPoints = default!;
            this.Surface = default!;
            this.Event = default!;
        }

        public CompetitionPoints CompetitionPoints { get; }

        public Surface Surface { get; }

        public Event Event { get; }
    }
}
