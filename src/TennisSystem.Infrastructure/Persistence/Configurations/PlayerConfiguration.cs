namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Players;

    using static Domain.Models.ModelConstants.Player;

    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .HasOne(p => p.Coach)
                .WithMany()
                .HasForeignKey("CoachId")
                .OnDelete(DeleteBehavior.Restrict);

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

                        p.OwnsOne(pl => pl.Backhand,
                            t =>
                            {
                                t.WithOwner();

                                t.Property(tr => tr.Value);
                            });

                        p.OwnsOne(pl => pl.Forehand,
                            t =>
                            {
                                t.WithOwner();

                                t.Property(tr => tr.Value);
                            });
                    });
                });
            
            builder
                .OwnsOne(p => p.Stats, s =>
                {
                    s.WithOwner();

                    s.Property(w => w.Win);
                    s.Property(w => w.Loss);
                    s.Property(w => w.Points);
                    s.Property(w => w.Rank);

                    s.OwnsMany(w => w.Titles, t =>
                    {
                        t.WithOwner();
                    });
                });

            builder
                .HasMany(p => p.Competitions)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("competitions");
        }
    }
}
