namespace TennisSystem.Domain.Models.Tournaments
{
    using FakeItEasy;
    using System;

    public class MatchFakes //: IDummyFactory
    {
        public bool CanCreate(Type type) => type == typeof(Match);

        //public object? Create(Type type) => new Match
        //(
        //    new Participant(
        //        "name",
        //        new Characteristics(
        //            22,
        //            "Country",
        //            70,
        //            175,
        //            new Play(Forehand.LeftHanded, Backhand.OneHanded)),
        //        new Stats(10, 8, 20)),
        //    new Participant(
        //        "name",
        //        new Characteristics(
        //            22,
        //            "Country",
        //            70,
        //            175,
        //            new Play(Forehand.LeftHanded, Backhand.OneHanded)),
        //        new Stats(20, 5, 6))
        //);

        public Priority Priority => Priority.Default;
    }
}
