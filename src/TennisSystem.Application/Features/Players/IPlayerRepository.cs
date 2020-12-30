namespace TennisSystem.Application.Features.Players
{
    using System.Threading;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Players;

    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> GetPlayer(int id, CancellationToken cancellationToken = default);
    }
}
