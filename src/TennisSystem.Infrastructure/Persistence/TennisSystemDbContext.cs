namespace TennisSystem.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;
    using TennisSystem.Domain.Models.Players;
    using TennisSystem.Domain.Models.Statistics;
    using TennisSystem.Domain.Models.Tournaments;

    internal class TennisSystemDbContext : DbContext
    {
        public TennisSystemDbContext(DbContextOptions<TennisSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Coach> Coaches { get; set; } = default!;

        public DbSet<Player> Players { get; set; } = default!;

        public DbSet<Statistic> Statistics { get; set; } = default!;

        public DbSet<Match> Matches { get; set; } = default!;

        public DbSet<Participant> Participants { get; set; } = default!;

        public DbSet<Tournament> Tournaments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
