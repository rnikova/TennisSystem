namespace TennisSystem.Domain.Models.Users
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.User;

    public class Consumer : Entity<int>, IAggregateRoot
    {
        internal Consumer(string username, string email)
        {
            this.ValidateUsername(username);

            this.Username = username;
            this.Email = email;
        }

        public string Username { get; private set; }

        public string Email { get; private set; }

        private void ValidateUsername(string username)
        {
            Guard.ForStringLength<InvalidUserException>(
                username,
                MinUsernameLength,
                MaxUsernameLength,
                nameof(this.Username));
        }
    }
}
