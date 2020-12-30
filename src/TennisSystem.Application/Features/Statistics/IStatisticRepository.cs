namespace TennisSystem.Application.Features.Statistics
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Statistics;

    public interface IStatisticRepository : IRepository<Statistic>
    {
        Task<IEnumerable<Statistic>> GetWomen();

        Task<IEnumerable<Statistic>> GetMen();
    }
}
