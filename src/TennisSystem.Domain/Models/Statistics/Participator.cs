namespace TennisSystem.Domain.Models.Statistics
{
    using TennisSystem.Domain.Common;
    using TennisSystem.Domain.Exceptions;

    using static ModelConstants.Player;
    using static ModelConstants.Statistic;

    public class Participator : Entity<int>
    {
        internal Participator(string name, int aces, int doubleFaults, int breakPoints)
        {
            this.ValidateName(name);
            this.ValidateAces(aces);
            this.ValidateDoubleFaults(doubleFaults);
            this.ValidateBreakPoints(breakPoints);

            this.Name = name;
            this.Aces = aces;
            this.DoubleFaults = doubleFaults;
            this.BreakPoints = breakPoints;
        }

        public string Name { get; private set; }

        public int Aces { get; private set; }

        public int DoubleFaults { get; set; }

        public int BreakPoints { get; private set; }

        public Participator Update(int aces, int doubleFaults, int breakPoints)
        {
            this.ValidateAces(aces);
            this.ValidateDoubleFaults(doubleFaults);
            this.ValidateBreakPoints(breakPoints);

            this.Aces += aces;
            this.DoubleFaults += doubleFaults;
            this.BreakPoints += breakPoints;

            return this;
        }

        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidStatisticException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
        
        private void ValidateAces(int aces)
        {
            Guard.AgainstOutOfRange<InvalidStatisticException>(
                aces,
                MinAces,
                MaxAces,
                nameof(this.Aces));
        }
        
        private void ValidateDoubleFaults(int doubleFaults)
        {
            Guard.AgainstOutOfRange<InvalidStatisticException>(
                doubleFaults,
                MinDoubleFaults,
                MaxDoubleFaults,
                nameof(this.Aces));
        }
        
        private void ValidateBreakPoints(int breakPoints)
        {
            Guard.AgainstOutOfRange<InvalidStatisticException>(
                breakPoints,
                MinBreakPoints,
                MaxBreakPoints,
                nameof(this.Aces));
        }
    }
}
