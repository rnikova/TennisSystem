using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Players
{
    public class Forehand : Enumeration
    {
        public static readonly Forehand RightHanded = new Forehand(1, nameof(RightHanded));
        public static readonly Forehand LeftHanded = new Forehand(2, nameof(LeftHanded));

        private Forehand(int value, string name)
            : base(value, name)
        {
        }

        private Forehand(int value)
            : this(value, FromValue<Forehand>(value).Name)
        {
        }
    }
}
