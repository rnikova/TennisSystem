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
               .OwnsOne(m => m.FirstPlayer, p =>
               {
                   p.WithOwner();

                   p.Property(po => po.Name);

                   p.OwnsOne(po => po.Characteristics, pc =>
                   {
                       pc.WithOwner();

                       pc.Property(ch => ch.Age);
                       pc.Property(ch => ch.Country);
                       pc.Property(ch => ch.Height);
                       pc.Property(ch => ch.Weight);

                       pc.OwnsOne(ch => ch.Play, p =>
                       {
                           p.WithOwner();

                           p.Property(pl => pl.Backhand);
                           p.Property(pl => pl.Forehand);
                       });
                   });

                   p.OwnsOne(p => p.Stats, s =>
                {
                    s.WithOwner();

                    s.Property(w => w.Win);
                    s.Property(w => w.Loss);
                    s.Property(w => w.Rank);
                });
               });

            builder
               .OwnsOne(m => m.SecondPlayer, p =>
               {
                   p.WithOwner();

                   p.Property(po => po.Name);

                   p.OwnsOne(po => po.Characteristics, pc =>
                   {
                       pc.WithOwner();

                       pc.Property(ch => ch.Age);
                       pc.Property(ch => ch.Country);
                       pc.Property(ch => ch.Height);
                       pc.Property(ch => ch.Weight);

                       pc.OwnsOne(ch => ch.Play, p =>
                       {
                           p.WithOwner();

                           p.Property(pl => pl.Backhand);
                           p.Property(pl => pl.Forehand);
                       });
                   });

                   p.OwnsOne(p => p.Stats, s =>
                   {
                       s.WithOwner();

                       s.Property(w => w.Win);
                       s.Property(w => w.Loss);
                       s.Property(w => w.Rank);
                   });
               });

            builder
                .HasMany(p => p.Result)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("result");
        }
    }
}
