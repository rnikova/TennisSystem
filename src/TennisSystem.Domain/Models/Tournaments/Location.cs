using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Location : ValueObject
    {
        internal Location(
            string country,
            string city)
        {
            this.Country = country;
            this.City = city;
        }

        public string Country { get; }

        public string City { get; }
    }
}
