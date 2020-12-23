namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;

    public class Participant : Entity<int>
    {
        internal Participant(
            string name,
            Characteristics characteristics,
            Stats stats)
        {
            this.ValidateName(name);

            this.Name = name;
            this.Characteristics = characteristics;
            this.Stats = stats;
        }

        private Participant(string name)
        {
            this.Name = name;

            this.Characteristics = default!;
            this.Stats = default!;
        }

        public string Name { get; private set; }

        public Characteristics Characteristics { get; private set; }

        public Stats Stats { get; private set; }

        public Participant UpdateName(string name)
        {
            this.ValidateName(name);

            return this;
        }

        public Participant UpdateStats(int win,
            int loss,
            int rank)
        {
            this.Stats = new Stats(win, loss, rank);

            return this;
        }
        public Participant UpdateCharacteristics(int age,
            string country,
            double weight,
            double height,
            Play play)
        {
            this.Characteristics = new Characteristics(age, country, weight, height, play);

            return this;
        }

        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidTournamentException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
    }
}
