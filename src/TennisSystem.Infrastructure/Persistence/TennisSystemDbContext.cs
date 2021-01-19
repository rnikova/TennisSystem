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

        public DbSet<Coach> Coaches { get; set; } = null!;

        public DbSet<Competition> Competitions { get; set; } = null!;

        public DbSet<Player> Players { get; set; } = null!;

        public DbSet<Participator> Participators { get; set; } = null!;

        public DbSet<Statistic> Statistics { get; set; } = null!;

        public DbSet<Match> Matches { get; set; } = null!;

        public DbSet<Participant> Participants { get; set; } = null!;

        public DbSet<Tournament> Tournaments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
