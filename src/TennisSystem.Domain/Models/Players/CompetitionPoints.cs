namespace TennisSystem.Domain.Models.Players
{
    using TennisSystem.Domain.Common;

    public class CompetitionPoints : Enumeration
    {
        public static readonly CompetitionPoints GrandSlam = new CompetitionPoints(1, nameof(GrandSlam));
        public static readonly CompetitionPoints t1000 = new CompetitionPoints(2, nameof(t1000));
        public static readonly CompetitionPoints t500 = new CompetitionPoints(3, nameof(t500));
        public static readonly CompetitionPoints t250 = new CompetitionPoints(4, nameof(t250));

        private CompetitionPoints(int value, string name)
            : base(value, name)
        {
        }

        private CompetitionPoints(int value)
            : this(value, FromValue<CompetitionPoints>(value).Name)
        {
        }
    }
}
