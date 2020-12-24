namespace TennisSystem.Infrastructure.Persistence.Repositories
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Common;

    internal class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        private readonly TennisSystemDbContext db;

        public DataRepository(TennisSystemDbContext db) => this.db = db;

        public IQueryable<TEntity> All() => this.db.Set<TEntity>();

        public Task<int> SaveChanges(CancellationToken cancellationToken = default)
            => this.db.SaveChangesAsync(cancellationToken);
    }
}
