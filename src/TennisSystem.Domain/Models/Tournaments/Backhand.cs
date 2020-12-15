namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;

    public class Backhand : Enumeration
    {
        public static readonly Backhand OneHanded = new Backhand(3, nameof(OneHanded));
        public static readonly Backhand TwoHanded = new Backhand(4, nameof(TwoHanded));

        private Backhand(int value, string name)
            : base(value, name)
        {
        }

        private Backhand(int value)
            : this(value, FromValue<Backhand>(value).Name)
        {
        }
    }
}
