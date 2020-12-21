namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Statistics;

    internal class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasMany(s => s.Men)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("men");
            
            builder
                .HasMany(s => s.Women)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("women");
        }
    }
}
