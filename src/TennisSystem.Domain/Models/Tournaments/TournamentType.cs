namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;

    public class TournamentType : ValueObject
    {
        internal TournamentType(
            TournamentPoints tournamentPoints,
            Surface surface,
            Event @event)
        {
            this.TournamentPoints = tournamentPoints;
            this.Surface = surface;
            this.Event = @event;
        }

        private TournamentType()
        {
            this.TournamentPoints = default!;
            this.Surface = default!;
            this.Event = default!;
        }

        public TournamentPoints TournamentPoints { get; }

        public Surface Surface { get; }

        public Event Event { get; }
    }
}
