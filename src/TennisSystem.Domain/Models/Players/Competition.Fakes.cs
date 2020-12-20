namespace TennisSystem.Domain.Models.Players
{
    using FakeItEasy;
    using System;

    public class CompetitionFakes : IDummyFactory
    {
        public bool CanCreate(Type type) => type == typeof(Competition);

        public object? Create(Type type) => new Competition
        (
            "Name",
            20000m,
            new CompetitionType(CompetitionPoints.t250, Surface.Hard, Event.ATP)
        );

        public Priority Priority => Priority.Default;
    }
}
