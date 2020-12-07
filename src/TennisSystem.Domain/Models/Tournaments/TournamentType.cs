using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class TournamentType : ValueObject
    {
        public TournamentPoints TournamentPoints { get; } = default!;

        public Surface Surface { get; } = default!;

        public Event Event { get; } = default!;
    }
}
