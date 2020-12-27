namespace TennisSystem.Domain.Factories.Players
{
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Players;

    internal class PlayerFactory : IPlayerFactory
    {
        private Characteristics playerCharacteristics = default!;
        private Coach playerCoach = default!;
        private string playerName = default!;
        private Stats playerStats = default!;

        private bool characteristicsSet = false;
        private bool coachSet = false;
        private bool statsSet = false;

        public IPlayerFactory WithCharacteristics(int age, string country, double weight, double height, Play play) 
            => this.WithCharacteristics(new Characteristics(age, country, weight, height, play));

        public IPlayerFactory WithCharacteristics(Characteristics characteristics)
        {
            this.playerCharacteristics = characteristics;
            this.characteristicsSet = true;
            return this;
        }

        public IPlayerFactory WithCoach(string coachName)
            => this.WithCoach(new Coach(coachName));

        public IPlayerFactory WithCoach(Coach coach)
        {
            this.playerCoach = coach;
            this.coachSet = true;
            return this;
        }

        public IPlayerFactory WithName(string name)
        {
            this.playerName = name;
            return this;
        }

        public IPlayerFactory WithStats(int win, int loss, int rank, int points)
            => this.WithStats(new Stats(win, loss, rank, points));

        public IPlayerFactory WithStats(Stats stats)
        {
            this.playerStats = stats;
            this.statsSet = true;
            return this;
        }
        public Player Build()
        {
            if (!this.statsSet || !this.coachSet || !this.characteristicsSet)
            {
                throw new InvalidPlayerException("Coach, characteristics and stats must have a value!");
            }

            return new Player(
                this.playerName,
                this.playerCoach,
                this.playerCharacteristics,
                this.playerStats);
        }
    }
}
