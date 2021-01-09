namespace TennisSystem.Infrastructure.Identity
{
    using Microsoft.AspNetCore.Identity;
    using TennisSystem.Domain.Models.Users;

    public class User : IdentityUser
    {
        internal User(string email)
            : base(email)
            => this.Email = email;

        public Consumer? Consumer { get; private set; }
    }
}
