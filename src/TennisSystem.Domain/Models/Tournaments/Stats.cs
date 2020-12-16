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
            int rank)
        {
            this.ValidateWin(win);
            this.ValidateLoss(loss);
            this.ValidateRank(rank);

            this.Win = win;
            this.Loss = loss;
            this.Rank = rank;
        }

        public int Win { get; private set; }

        public int Loss { get; private set; }

        public int Rank { get; private set; }

        public Stats Update(int win, int loss, int rank)
        {
            this.ValidateWin(win);
            this.ValidateLoss(loss);

            this.Win += win;
            this.Loss += loss;
            this.Rank += rank;

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
    }
}