namespace TennisSystem.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Infrastructure.Persistence;
    using TennisSystem.Infrastructure.Persistence.Repositories;

    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDatabase(configuration);

        private static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<TennisSystemDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(TennisSystemDbContext)
                            .Assembly.FullName)))
                .AddTransient<IInitializer, TennisSystemDbInitializer>()
                .AddTransient(typeof(IRepository<>), typeof(DataRepository<>));
    }
}
