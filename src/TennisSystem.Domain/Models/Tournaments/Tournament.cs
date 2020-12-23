namespace TennisSystem.Domain.Models.Tournaments
{
    using System.Linq;
    using System.Collections.Generic;
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Tournament;
    using static ModelConstants.Common;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Match> matches;

        internal Tournament(
            string name,
            decimal prize,
            Location location,
            TournamentType tournamentType)
        {
            this.Validate(name, prize);

            this.Name = name;
            this.Prize = prize;
            this.Location = location;
            this.TournamentType = tournamentType;

            this.matches = new HashSet<Match>();
        }

        private Tournament(
            string name,
            decimal prize)
        {
            this.Name = name;
            this.Prize = prize;

            this.Location = default!;
            this.TournamentType = default!;

            this.matches = new HashSet<Match>();
        }

        public string Name { get; private set; }

        public decimal Prize { get; private set; }

        public Location Location { get; private set; }

        public TournamentType TournamentType { get; private set; }

        public IReadOnlyCollection<Match> Matches => this.matches.ToList().AsReadOnly();

        public void AddMatch(Match match) => this.matches.Add(match);

        public void RemoveMatch(Match match) => this.matches.Remove(match);

        private void Validate(string name, decimal prize)
        {
            Guard.ForStringLength<InvalidTournamentException>(
                name,
                MinTournamentLength,
                MaxTournamentLength,
                nameof(this.Name));

            Guard.AgainstOutOfRange<InvalidTournamentException>(
                prize,
                MinPrize,
                MaxPrize,
                nameof(this.Prize));
        }
    }
}
