namespace TennisSystem.Application.Features.Players
{
    using System.Threading;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Players;

    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> AddPlayer(Player player, CancellationToken cancellationToken = default);

        Task<Player> UpdatePlayer(Player player, CancellationToken cancellationToken = default);

        Task<Player> ChangeCoach(Player player, CancellationToken cancellationToken = default);

        Task<Player> UpdateStats(Stats stats, CancellationToken cancellationToken = default);

        Task<Player> GetPlayer(int id, CancellationToken cancellationToken = default);

        Task<bool> DeletePlayer(int id, CancellationToken cancellationToken = default);
    }
}
