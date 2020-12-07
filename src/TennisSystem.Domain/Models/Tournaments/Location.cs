using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Location : ValueObject
    {
        public string Country { get; } = default!;

        public string City { get; } = default!;
    }
}
