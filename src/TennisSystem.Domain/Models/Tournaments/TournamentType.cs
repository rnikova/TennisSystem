using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
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

        public TournamentPoints TournamentPoints { get; }

        public Surface Surface { get; }

        public Event Event { get; }
    }
}
