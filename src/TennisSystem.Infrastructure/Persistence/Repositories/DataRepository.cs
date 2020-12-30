namespace TennisSystem.Infrastructure.Persistence.Repositories
{
    using System.Linq;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Common;

    internal abstract class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        private readonly TennisSystemDbContext db;

        protected DataRepository(TennisSystemDbContext db) => this.db = db;

        protected IQueryable<TEntity> All() => this.db.Set<TEntity>();
    }
}
