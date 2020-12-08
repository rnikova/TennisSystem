using CarRentalSystem.Domain.Common;
using System.Collections.Generic;
using System.Linq;
using TennisSystem.Domain.Models.Players;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> players;

        internal Tournament(
            string name,
            decimal prize,
            Location location,
            TournamentType tournamentType)
        {
            this.Name = name;
            this.Prize = prize;
            this.Location = location;
            this.TournamentType = tournamentType;

            this.players = new HashSet<Player>();
        }

        public string Name { get; private set; }

        public decimal Prize { get; private set; }

        public Location Location { get; private set; }

        public TournamentType TournamentType { get; private set; }

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();
    }
}
