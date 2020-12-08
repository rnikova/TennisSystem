using CarRentalSystem.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace TennisSystem.Domain.Models.Players
{
    public class Stats : ValueObject
    {
        private readonly HashSet<Title> titles;

        internal Stats(
            int win,
            int loss,
            int rank,
            int points)
        {
            this.Win = win;
            this.Loss = loss;
            this.Rank = rank;
            this.Points = points;

            this.titles = new HashSet<Title>();
        }

        public int Win { get; private set; }

        public int Loss { get; private set; }

        public int Rank { get; private set; }

        public int Points { get; private set; }

        public IReadOnlyCollection<Title> Titles => this.titles.ToList().AsReadOnly();
    }
}
