using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Players
{
    public class Title : ValueObject
    {
        public Title(
            string tournament,
            int year)
        {
            this.Tournament = tournament;
            this.Year = year;
        }

        public string Tournament { get; }

        public int Year { get; }

    }
}
