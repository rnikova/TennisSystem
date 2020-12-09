namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using System.Collections.Generic;
    using System.Linq;
    using TennisSystem.Domain.Models.Tournaments;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;

    public class Player : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Tournament> tournaments;

        public Player(
            string name,
            string coach,
            Characteristics characteristics,
            Stats stats)
        {
            this.Validate(name, coach);

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

        private void Validate(string name, string coach)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

            Guard.ForStringLength<InvalidTournamentException>(
                coach,
                MinNameLength,
                MaxNameLength,
                nameof(this.Coach));
        }
    }
}
