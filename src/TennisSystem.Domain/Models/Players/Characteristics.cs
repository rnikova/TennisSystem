﻿namespace TennisSystem.Domain.Models.Players
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
            PlayStile playStile)
        {
            this.Validate(age, country, weight, height);

            this.Age = age;
            this.Country = country;
            this.Weight = weight;
            this.Height = height;
            this.Play = playStile;
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

        public PlayStile Play { get; }

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

            Guard.AgainstOutOfRange<InvalidPlayerException>(
                weight,
                MinWeight,
                MaxWeight,
                nameof(this.Weight));
            
            Guard.AgainstOutOfRange<InvalidPlayerException>(
                heigth,
                MinHeight,
                MaxHeight,
                nameof(this.Height));
        }
    }
}
