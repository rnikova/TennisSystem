namespace TennisSystem.Domain.Models.Tournaments
{
    using FakeItEasy;
    using System;

    public class ParticipantFakes : IDummyFactory
    {
        public bool CanCreate(Type type) => type == typeof(Participant);

        public object? Create(Type type) => new Participant
        (
            "Name",
            new Characteristics(
                20,
                "Bulgaria",
                70,
                178.0,
                new Play(Forehand.LeftHanded, Backhand.OneHanded)),
            new Stats(20, 10, 5)
        );

        public Priority Priority => Priority.Default;
    }
}
