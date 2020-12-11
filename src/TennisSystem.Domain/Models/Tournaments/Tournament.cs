namespace TennisSystem.Domain.Models.Tournaments
{
    using System.Linq;
    using System.Collections.Generic;
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Players;

    using static ModelConstants.Tournament;
    using static ModelConstants.Common;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> players;

        public Tournament(
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

            this.players = new HashSet<Player>();
        }

        public string Name { get; private set; }

        public decimal Prize { get; private set; }

        public Location Location { get; private set; }

        public TournamentType TournamentType { get; private set; }

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();

        public void AddPlayer(Player player) => this.players.Add(player);

        public void RemovePlayer(Player player) => this.players.Remove(player);

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
