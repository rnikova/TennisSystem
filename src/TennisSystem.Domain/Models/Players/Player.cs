namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;

    public class Player : Entity<int>, IAggregateRoot
    {
        internal Player(
            string name,
            Coach coach,
            Characteristics characteristics,
            Stats stats)
        {
            this.ValidateName(name);

            this.Name = name;
            this.Coach = coach;
            this.Characteristics = characteristics;
            this.Stats = stats;
        }

        private Player(
            string name)
        {
            this.Name = name;

            this.Coach = default!;
            this.Characteristics = default!;
            this.Stats = default!;
        }

        public string Name { get; private set; }

        public Coach Coach { get; private set; }

        public Characteristics Characteristics { get; private set; }

        public Stats Stats { get; private set; }

        public Player UpdateName(string name)
        {
            ValidateName(name);

            return this;
        }

        public Player UpdateStats(int win,
            int loss,
            int rank,
            int points)
        {
            this.Stats = new Stats(win, loss, rank, points);

            return this;
        }
        public Player UpdateCharacteristics(int age,
            string country,
            double weight,
            double height,
            PlayStile play)
        {
            this.Characteristics = new Characteristics(age, country, weight, height, play);

            return this;
        }

        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
    }
}
