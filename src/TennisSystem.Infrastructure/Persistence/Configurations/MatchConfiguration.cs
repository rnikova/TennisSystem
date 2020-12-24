namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Tournaments;

    internal class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
               .HasOne(m => m.FirstPlayer)
               .WithMany()
               .HasForeignKey("ParticipantId")
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(m => m.SecondPlayer)
               .WithMany()
               .HasForeignKey("ParticipantId")
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .OwnsMany(m => m.Result,
                    s =>
                    {
                        s.Property(st => st.FirstParticipantPoints);
                        s.Property(st => st.SecondParticipantPoints);
                    });
        }
    }
}
