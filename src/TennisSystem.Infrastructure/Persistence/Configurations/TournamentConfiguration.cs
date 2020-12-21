namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Tournaments;

    using static Domain.Models.ModelConstants.Tournament;
    using static Domain.Models.ModelConstants.Common;

    internal class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(MaxTournamentLength);

            builder
                .Property(t => t.Prize)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder
                .OwnsOne(t => t.Location, s =>
                {
                    s.WithOwner();

                    s.Property(l => l.Country);
                    s.Property(l => l.City);
                });
            
            builder
                .OwnsOne(t => t.TournamentType, s =>
                {
                    s.WithOwner();

                    s.Property(l => l.Event);
                    s.Property(l => l.Surface);
                    s.Property(l => l.TournamentPoints);
                });

            builder
               .HasMany(t => t.Matches)
               .WithOne()
               .Metadata
               .PrincipalToDependent
               .SetField("matches");
        }
    }
}
