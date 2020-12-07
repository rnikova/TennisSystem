using CarRentalSystem.Domain.Common;
using System.Collections.Generic;
using System.Linq;
using TennisSystem.Domain.Models.Players;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> players;

        public Tournament()
        {
            this.players = new HashSet<Player>();
        }

        public string Name { get; private set; } = default!;

        public decimal Price { get; private set; }

        public Location Location { get; private set; } = default!;

        public TournamentType TournamentType { get; private set; } = default!;

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();
    }
}
