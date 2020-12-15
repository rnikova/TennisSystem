namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Stats;

    public class Stats : ValueObject
    {
        internal Stats(
            int win,
            int loss,
            int rank,
            int points)
        {
            this.ValidateWin(win);
            this.ValidateLoss(loss);
            this.ValidateRank(rank);
            this.ValidatePoints(points);

            this.Win = win;
            this.Loss = loss;
            this.Rank = rank;
            this.Points = points;
        }

        public int Win { get; private set; }

        public int Loss { get; private set; }

        public int Rank { get; private set; }

        public int Points { get; private set; }

        public Stats Update(int win, int loss, int rank, int points)
        {
            this.ValidateWin(win);
            this.ValidateLoss(loss);

            this.Win += win;
            this.Loss += loss;
            this.Rank += rank;
            this.Points += points;

            return this;
        }

        private void ValidateWin(int win)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                win,
                MinWin,
                MaxWin,
                nameof(this.Win));
        }

        private void ValidateLoss(int loss)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                loss,
                MinLoss,
                MaxLoss,
                nameof(this.Loss));
        }

        private void ValidateRank(int rank)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                rank,
                MinRank,
                MaxRank,
                nameof(this.Rank));
        }

        private void ValidatePoints(int points)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                points,
                MinPoints,
                MaxPoints,
                nameof(this.Points));
        }
    }
}