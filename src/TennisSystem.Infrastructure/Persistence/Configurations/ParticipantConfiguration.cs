namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Tournaments;

    using static Domain.Models.ModelConstants.Player;

    internal class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .OwnsOne(p => p.Characteristics, c =>
                {
                    c.WithOwner();

                    c.Property(ch => ch.Age);
                    c.Property(ch => ch.Country);
                    c.Property(ch => ch.Height);
                    c.Property(ch => ch.Weight);

                    c.OwnsOne(ch => ch.Play, p =>
                    {
                        p.WithOwner();

                        p.Property(pl => pl.Backhand);
                        p.Property(pl => pl.Forehand);
                    });
                });

            builder
                .OwnsOne(p => p.Stats, s =>
                {
                    s.WithOwner();

                    s.Property(w => w.Win);
                    s.Property(w => w.Loss);
                    s.Property(w => w.Rank);
                });
        }
    }
}
