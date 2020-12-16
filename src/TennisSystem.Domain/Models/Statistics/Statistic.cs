namespace TennisSystem.Domain.Models.Statistics
{
    using System.Linq;
    using System.Collections.Generic;
    using TennisSystem.Domain.Common;

    public class Statistic : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> men;
        private readonly HashSet<Player> women;

        internal Statistic()
        {
            this.men = new HashSet<Player>();
            this.women = new HashSet<Player>();
        }

        public IReadOnlyCollection<Player> Men => this.men.ToList().AsReadOnly();

        public IReadOnlyCollection<Player> Women => this.women.ToList().AsReadOnly();

        public void AddMan(Player player) => this.men.Add(player);

        public void AddWoman(Player player) => this.women.Add(player);
    }
}
