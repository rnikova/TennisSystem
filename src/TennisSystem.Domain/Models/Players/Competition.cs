namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Tournament;
    using static ModelConstants.Common;

    public class Competition : ValueObject
    {
        internal Competition(
               string name,
               decimal prize,
               CompetitionType tournamentType)
        {
            this.Validate(name, prize);

            this.Name = name;
            this.Prize = prize;
            this.TournamentType = tournamentType;
        }

        public string Name { get; private set; }

        public decimal Prize { get; private set; }

        public CompetitionType TournamentType { get; private set; }

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