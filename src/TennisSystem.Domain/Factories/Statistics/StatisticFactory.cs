using TennisSystem.Domain.Models.Statistics;

namespace TennisSystem.Domain.Factories.Statistics
{
    internal class StatisticFactory : IStatisticFactory
    {
        public Statistic Build()
        {
            return new Statistic();
        }
    }
}
