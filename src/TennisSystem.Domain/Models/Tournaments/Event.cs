namespace TennisSystem.Domain.Models.Tournaments
{
    using TennisSystem.Domain.Common;

    public class Event : Enumeration
    {
        public static readonly Event ATP = new Event(1, nameof(ATP));
        public static readonly Event WTA = new Event(2, nameof(WTA));
        public static readonly Event Double = new Event(3, nameof(Double));
        public static readonly Event Mixed = new Event(3, nameof(Mixed));

        private Event(int value, string name)
            : base(value, name)
        {
        }

        private Event(int value)
            : this(value, FromValue<Event>(value).Name)
        {
        }
    }
}
