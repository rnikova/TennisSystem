namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Models.Players;

    public class Match : Entity<int>
    {
        internal Match(Player first, Player second)
        {
            this.FirstPlayer = first;
            this.SecondPlayer = second;
        }

        public Player FirstPlayer { get; private set; }

        public Player SecondPlayer { get; private set; }
    }
}
