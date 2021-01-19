namespace TennisSystem.Application.Features.Tournaments
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Players;
    using TennisSystem.Domain.Models.Tournaments;

    public interface ITournamentRepository : IRepository<Tournament>
    {
        Task<Tournament> AddTournament(Tournament tournament, CancellationToken cancellationToken = default);

        Task<bool> AddPlayer(Player player, CancellationToken cancellationToken = default);

        Task<bool> DeletePlayer(Player player, CancellationToken cancellationToken = default);

        Task<bool> AddMatch(Player firstPlayer, Player secondPlayer, CancellationToken cancellationToken = default);

        Task<bool> ChangeMatch(Player firstPlayer, Player secondPlayer, CancellationToken cancellationToken = default);

        Task<bool> SetMatchResult(Set set, CancellationToken cancellationToken = default);

        Task<Tournament> ChangeLocation(Location location, CancellationToken cancellationToken = default);

        Task<Tournament> ChangePrize(decimal prize, CancellationToken cancellationToken = default);

        Task<Tournament> GetTournament(int id, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetMatchesByPlayertId(int participantId, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetBySurface(string surface, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetByEvent(string @event, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetByTournamentPoints(string tournamentPoints, CancellationToken cancellationToken = default);
    }
}
