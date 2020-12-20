namespace TennisSystem.Domain.Models.Statistics
{
    using System.Linq;
    using System.Collections.Generic;
    using TennisSystem.Domain.Common;

    public class Statistic : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Participator> men;
        private readonly HashSet<Participator> women;

        internal Statistic()
        {
            this.men = new HashSet<Participator>();
            this.women = new HashSet<Participator>();
        }

        public IReadOnlyCollection<Participator> Men => this.men.ToList().AsReadOnly();

        public IReadOnlyCollection<Participator> Women => this.women.ToList().AsReadOnly();

        public void AddMan(Participator player) => this.men.Add(player);

        public void AddWoman(Participator player) => this.women.Add(player);
    }
}
