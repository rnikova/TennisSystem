namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using System.Collections.Generic;
    using System.Linq;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;

    public class Player : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Tournament> tournaments;

        internal Player(
            string name,
            Coach coach,
            Characteristics characteristics,
            Stats stats)
        {
            this.ValidateName(name);

            this.Name = name;
            this.Coach = coach;
            this.Characteristics = characteristics;
            this.Stats = stats;

            this.tournaments = new HashSet<Tournament>();
        }

        public string Name { get; private set; }

        public Coach Coach { get; private set; }

        public Characteristics Characteristics { get; private set; }

        public Stats Stats { get; private set; }

        public IReadOnlyCollection<Tournament> Tournaments => this.tournaments.ToList().AsReadOnly();

        public void AddTournament(Tournament tournament) => this.tournaments.Add(tournament);

        public void RemoveTournament(Tournament tournament) => this.tournaments.Remove(tournament);

        public Player UpdateName(string name)
        {
            ValidateName(name);

            return this;
        }

        public Player UpdateStats(int win,
            int loss,
            int rank,
            int points)
        {
            this.Stats = new Stats(win, loss, rank, points);

            return this;
        }
        public Player UpdateCharacteristics(int age,
            string country,
            double weight,
            double height,
            Play play)
        {
            this.Characteristics = new Characteristics(age, country, weight, height, play);

            return this;
        }

        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
    }
}
