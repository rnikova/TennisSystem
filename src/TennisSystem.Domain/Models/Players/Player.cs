using CarRentalSystem.Domain.Common;
using System.Collections.Generic;
using System.Linq;
using TennisSystem.Domain.Models.Tournaments;

namespace TennisSystem.Domain.Models.Players
{
    public class Player : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Tournament> tournaments;

        internal Player(
            string name,
            string coach,
            Characteristics characteristics,
            Stats stats)
        {
            this.Name = name;
            this.Coach = coach;
            this.Characteristics = characteristics;
            this.Stats = stats;

            this.tournaments = new HashSet<Tournament>();
        }

        public string Name { get; private set; }

        public string Coach { get; private set; }

        public Characteristics Characteristics { get; private set; }

        public Stats Stats { get; private set; }

        public IReadOnlyCollection<Tournament> Tournaments => this.tournaments.ToList().AsReadOnly();
    }
}
