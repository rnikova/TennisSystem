namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;

    public class Coach : Entity<int>
    {
        internal Coach(string name)
        {
            this.Validate(name);
            this.Name = name;
        }

        public string Name { get; set; }

        private void Validate(string name)
        {
            Guard.ForStringLength<InvalidPlayerException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }

        public Coach Update(string coach)
        {
            Validate(coach);

            return this;
        }
    }
}
