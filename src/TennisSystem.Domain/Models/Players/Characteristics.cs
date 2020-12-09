namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Location;
    using static ModelConstants.Player;

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

        public int Age { get; }

        public string Country { get; }

        public double Weight { get; }

        public double Height { get; }

        public Play Play { get; }

        private void Validate(int age, string country, double weight, double heigth)
        {
            Guard.AgainstOutOfRange<InvalidPlayerException>(
                age,
                MinAge,
                MaxAge,
                nameof(this.Age));

            Guard.ForStringLength<InvalidPlayerException>(
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
