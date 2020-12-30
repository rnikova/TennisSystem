namespace TennisSystem.Application.Contracts
{
    using TennisSystem.Domain.Common;

    public interface IRepository<out TEntity>
         where TEntity : IAggregateRoot
    {
    }
}
