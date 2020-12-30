namespace TennisSystem.Application.Features.Tournaments
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Tournaments;

    public interface ITournamentRepository : IRepository<Tournament>
    {
        Task<Tournament> GetTournament(int id, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetMatchesByParticipantId(int participantId, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetBySurface(string surface, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetByEvent(string @event, CancellationToken cancellationToken = default);

        Task<IEnumerable<Tournament>> GetByTournamentPoints(string tournamentPoints, CancellationToken cancellationToken = default);
    }
}
