namespace TennisSystem.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;

    internal class TennisSystemDbInitializer : IInitializer
    {
        private readonly TennisSystemDbContext db;

        public TennisSystemDbInitializer(TennisSystemDbContext db) => this.db = db;

        public void Initialize() => this.db.Database.Migrate();
    }
}