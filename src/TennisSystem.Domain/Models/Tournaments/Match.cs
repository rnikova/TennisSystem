namespace TennisSystem.Domain.Models.Tournaments
{
    using System.Collections.Generic;
    using System.Linq;
    using TennisSystem.Domain.Common;

    public class Match : Entity<int>
    {
        private readonly List<Set> result;

        internal Match(Participant first, Participant second)
        {
            this.FirstPlayer = first;
            this.SecondPlayer = second;

            this.result = new List<Set>();
        }

        private Match()
        {
            this.FirstPlayer = default!;
            this.SecondPlayer = default!;

            this.result = new List<Set>();
        }

        public Participant FirstPlayer { get; private set; }

        public Participant SecondPlayer { get; private set; }

        public IReadOnlyCollection<Set> Result => this.result.ToList().AsReadOnly();

        public void UpdateResult(int firstParticipantPoints, int secondPartisipantPoints)
        {
            var set = new Set(firstParticipantPoints, secondPartisipantPoints);

            this.result.Add(set);
        }
    }
}
