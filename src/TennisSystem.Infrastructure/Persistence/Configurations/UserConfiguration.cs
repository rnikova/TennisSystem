namespace TennisSystem.Infrastructure.Persistence.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisSystem.Domain.Models.Users;

    using static TennisSystem.Domain.Models.ModelConstants.User;

    internal class UserConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(MaxUsernameLength);

            builder
                .Property(u => u.Email)
                .IsRequired();
        }
    }
}
