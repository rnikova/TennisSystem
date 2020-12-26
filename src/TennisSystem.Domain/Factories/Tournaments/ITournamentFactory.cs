﻿namespace TennisSystem.Domain.Factories.Statistics
{
    using TennisSystem.Domain.Models.Tournaments;

    public interface ITournamentFactory : IFactory<Tournament>
    {
        ITournamentFactory WithName(string name);

        ITournamentFactory WithPrize(decimal prize);

        ITournamentFactory WithLocation(Location location);

        ITournamentFactory WithLocation(string contry, string city);

        ITournamentFactory WithTournamentType(TournamentType tournamentType);

        ITournamentFactory WithTournamentType(TournamentPoints tournamentPoints, Surface surface, Event @event);
    }
}
