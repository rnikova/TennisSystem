namespace TennisSystem.Domain.Factories.Players
{
    using TennisSystem.Domain.Models.Players;

    public interface IPlayerFactory : IFactory<Player>
    {
        IPlayerFactory WithName(string name);

        IPlayerFactory WithCoach(string coachName);

        IPlayerFactory WithCoach(Coach coach);

        IPlayerFactory WithCharacteristics(int age, string country, double weight, double height, PlayStile play);

        IPlayerFactory WithCharacteristics(Characteristics characteristics);

        IPlayerFactory WithStats(int win, int loss, int rank, int points);

        IPlayerFactory WithStats(Stats stats);
    }
}
