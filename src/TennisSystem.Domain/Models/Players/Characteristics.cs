using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Players
{
    public class Characteristics : ValueObject
    {
        internal Characteristics(
            int age,
            string country,
            double weight,
            double height,
            Play play)
        {
            this.Age = age;
            this.Country = country;
            this.Weight = weight;
            this.Height = height;
            this.Play = play;
        }

        public int Age { get; }

        public string Country { get; }

        public double Weight { get; }

        public double Height { get; }

        public Play Play { get; }
    }
}
