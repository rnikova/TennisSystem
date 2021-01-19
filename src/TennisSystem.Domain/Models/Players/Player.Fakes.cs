namespace TennisSystem.Domain.Models.Players
{
    using FakeItEasy;
    using System;

    public class PlayerFakes : IDummyFactory
    {
        public bool CanCreate(Type type) => type == typeof(Player);

        public object? Create(Type type) => new Player
        (
            "Name",
            new Coach("Coach"),
            new Characteristics(
                20,
                "Bulgaria",
                70,
                178.0,
                new PlayStile(Forehand.LeftHanded, Backhand.OneHanded)),
            new Stats(20, 10, 5, 3000)
        );

        public Priority Priority => Priority.Default;
    }
}
