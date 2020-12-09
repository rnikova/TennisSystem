namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Common;
    using static ModelConstants.Title;

    public class Title : ValueObject
    {
        internal Title(
            string tournament,
            int year)
        {
            this.Validate(tournament, year);

            this.Tournament = tournament;
            this.Year = year;
        }

        public string Tournament { get; }

        public int Year { get; }

        private void Validate(string tournament, int year)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                tournament,
                MinTournamentLength,
                MaxTournamentLength,
                nameof(this.Tournament));

            Guard.AgainstOutOfRange<InvalidTournamentException>(
                year,
                MinYear,
                MaxYear,
                nameof(this.Year));
        }
    }
}
