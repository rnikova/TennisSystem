﻿namespace TennisSystem.Domain.Models.Players
{
    using FakeItEasy;
    using System;

    public class TournamentFakes : IDummyFactory
    {
        public bool CanCreate(Type type) => type == typeof(Tournament);

        public object? Create(Type type) => new Tournament
        (
            "Name",
            20000m,
            new TournamentType(TournamentPoints.t250, Surface.Hard, Event.ATP)
        );

        public Priority Priority => Priority.Default;
    }
}
