namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Statistics;

    using static Domain.Models.ModelConstants.Player;

    public class ParticipatorConfiguration : IEntityTypeConfiguration<Participator>
    {
        public void Configure(EntityTypeBuilder<Participator> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(p => p.Aces)
                .IsRequired()
                .HasColumnType("int");
            
            builder
                .Property(p => p.DoubleFaults)
                .IsRequired()
                .HasColumnType("int");
            
            builder
                .Property(p => p.BreakPoints)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
