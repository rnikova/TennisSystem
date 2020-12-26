namespace TennisSystem.Domain.Factories
{
    using TennisSystem.Domain.Common;

    public interface IFactory<out TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}
