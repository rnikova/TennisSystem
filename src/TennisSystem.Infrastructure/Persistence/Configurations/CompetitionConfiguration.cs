namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Players;

    using static Domain.Models.ModelConstants.Common;

    public class CompetitionConfiguration : IEntityTypeConfiguration<Competition>
    {
        public void Configure(EntityTypeBuilder<Competition> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxTournamentLength);

            builder
                            .Property(t => t.Prize)
                            .IsRequired()
                            .HasColumnType("decimal(18,2)");

            builder
                .OwnsOne(t => t.CompetitionType, s =>
                {
                    s.WithOwner();

                    s.OwnsOne(l => l.CompetitionPoints,
                        t =>
                        {
                            t.WithOwner();

                            t.Property(tr => tr.Value);
                        });

                    s.OwnsOne(l => l.Surface,
                        t =>
                        {
                            t.WithOwner();

                            t.Property(tr => tr.Value);
                        });

                    s.OwnsOne(l => l.Event,
                        t =>
                        {
                            t.WithOwner();

                            t.Property(tr => tr.Value);
                        });
                });
        }
    }
}