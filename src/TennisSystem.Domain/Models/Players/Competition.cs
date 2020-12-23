namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Tournament;
    using static ModelConstants.Common;

    public class Competition : Entity<int>
    {
        internal Competition(
               string name,
               decimal prize,
               CompetitionType tournamentType)
        {
            this.Validate(name, prize);

            this.Name = name;
            this.Prize = prize;
            this.CompetitionType = tournamentType;
        }

        private Competition(
            string name,
            decimal prize)
        {
            this.Name = name;
            this.Prize = prize;

            this.CompetitionType = default!;
        }

        public string Name { get; private set; }

        public decimal Prize { get; private set; }

        public CompetitionType CompetitionType { get; private set; }

        private void Validate(string name, decimal prize)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                name,
                MinTournamentLength,
                MaxTournamentLength,
                nameof(this.Name));

            Guard.AgainstOutOfRange<InvalidPlayerException>(
                prize,
                MinPrize,
                MaxPrize,
                nameof(this.Prize));
        }
    }
}