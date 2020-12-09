namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using System.Collections.Generic;
    using System.Linq;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Stats;

    public class Stats : ValueObject
    {
        private readonly HashSet<Title> titles;

        internal Stats(
            int win,
            int loss,
            int rank,
            int points)
        {
            this.Validate(win, loss, rank, points);

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

        private void Validate(int win, int loss, int rank, int points)
        {
            Guard.AgainstOutOfRange<InvalidPlayerException>(
                win,
                MinWin,
                MaxWin,
                nameof(this.Win));

            Guard.AgainstOutOfRange<InvalidPlayerException>(
                loss,
                MinLoss,
                MaxLoss,
                nameof(this.Loss));
            
            Guard.AgainstOutOfRange<InvalidPlayerException>(
                rank,
                MinRank,
                MaxRank,
                nameof(this.Rank));
            
            Guard.AgainstOutOfRange<InvalidPlayerException>(
                points,
                MinPoints,
                MaxPoints,
                nameof(this.Points));
        }
    }
}
