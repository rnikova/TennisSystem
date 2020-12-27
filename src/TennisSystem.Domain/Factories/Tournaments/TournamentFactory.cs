namespace TennisSystem.Domain.Factories.Tournaments
{
    using TennisSystem.Domain.Exceptions;
    using TennisSystem.Domain.Models.Tournaments;

    internal class TournamentFactory : ITournamentFactory
    {
        private Location tournamentLocation = default!;
        private string tournamentName = default!;
        private decimal tournamentPrize = default!;
        private TournamentType tournamentType = default!;

        private bool setLocation = false;
        private bool setTournamentType = false;

        public ITournamentFactory WithLocation(Location location)
        {
            this.tournamentLocation = location;
            this.setLocation = true;
            return this;
        }

        public ITournamentFactory WithLocation(string country, string city)
            => this.WithLocation(new Location(country, city));

        public ITournamentFactory WithName(string name)
        {
            this.tournamentName = name;
            return this;
        }

        public ITournamentFactory WithPrize(decimal prize)
        {
            this.tournamentPrize = prize;
            return this;
        }

        public ITournamentFactory WithTournamentType(TournamentType tournamentType)
        {
            this.tournamentType = tournamentType;
            this.setTournamentType = true;
            return this;
        }

        public ITournamentFactory WithTournamentType(TournamentPoints tournamentPoints, Surface surface, Event @event)
            => this.WithTournamentType(new TournamentType(tournamentPoints, surface, @event));

        public Tournament Build()
        {
            if (!this.setLocation || !this.setTournamentType)
            {
                throw new InvalidTournamentException("Location and tournament type must have a value!");
            }

            return new Tournament(
                this.tournamentName,
                this.tournamentPrize,
                this.tournamentLocation,
                this.tournamentType);
        }
    }
}
