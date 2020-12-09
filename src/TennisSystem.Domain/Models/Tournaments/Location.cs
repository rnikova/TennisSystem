namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Location;

    public class Location : ValueObject
    {
        internal Location(
            string country,
            string city)
        {
            this.Validate(country, city);

            this.Country = country;
            this.City = city;
        }

        public string Country { get; }

        public string City { get; }

        private void Validate(string country, string city)
        {
            Guard.ForStringLength<InvalidTournamentException>(
                country,
                MinLocationLength,
                MaxLocationLength,
                nameof(this.Country));

            Guard.ForStringLength<InvalidTournamentException>(
                city,
                MinLocationLength,
                MaxLocationLength,
                nameof(this.City));
        }
    }
}
