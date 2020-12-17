namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;

    public class Surface : Enumeration
    {
        public static readonly Surface Grass = new Surface(1, nameof(Grass));
        public static readonly Surface Clay = new Surface(2, nameof(Clay));
        public static readonly Surface Hard = new Surface(3, nameof(Hard));

        private Surface(int value, string name)
            : base(value, name)
        {
        }

        private Surface(int value)
            : this(value, FromValue<Surface>(value).Name)
        {
        }
    }
}
