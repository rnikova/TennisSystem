﻿using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class TournamentPoints : Enumeration
    {
        public static readonly TournamentPoints GrandSlam = new TournamentPoints(1, nameof(GrandSlam));
        public static readonly TournamentPoints t1000 = new TournamentPoints(2, nameof(t1000));
        public static readonly TournamentPoints t500 = new TournamentPoints(3, nameof(t500));
        public static readonly TournamentPoints t250 = new TournamentPoints(4, nameof(t250));

        public TournamentPoints(int value, string name) 
            : base(value, name)
        {
        }
    }
}