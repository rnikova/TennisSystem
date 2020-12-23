namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;
    using static ModelConstants.Location;

    public class Characteristics : ValueObject
    {
        internal Characteristics(
            int age,
            string country,
            double weight,
            double height,
            Play play)
        {
            this.Validate(age, country, weight, height);

            this.Age = age;
            this.Country = country;
            this.Weight = weight;
            this.Height = height;
            this.Play = play;
        }

        private Characteristics(
            int age,
            string country,
            double weight,
            double height)
        {
            this.Age = age;
            this.Country = country;
            this.Weight = weight;
            this.Height = height;

            this.Play = default!;
        }

        public int Age { get; }

        public string Country { get; }

        public double Weight { get; }

        public double Height { get; }

        public Play Play { get; }

        private void Validate(int age, string country, double weight, double heigth)
        {
            Guard.AgainstOutOfRange<InvalidTournamentException>(
                age,
                MinAge,
                MaxAge,
                nameof(this.Age));

            Guard.ForStringLength<InvalidTournamentException>(
                country,
                MinLocationLength,
                MaxLocationLength,
                nameof(this.Country));

            Guard.AgainstOutOfRange<InvalidTournamentException>(
                weight,
                MinWeight,
                MaxWeight,
                nameof(this.Weight));

            Guard.AgainstOutOfRange<InvalidTournamentException>(
                heigth,
                MinHeight,
                MaxHeight,
                nameof(this.Height));
        }
    }
}