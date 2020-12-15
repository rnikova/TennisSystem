namespace TennisSystem.Domain.Models
{
    public class ModelConstants
    {
        public class Common
        {
            public const int MinTournamentLength = 2;
            public const int MaxTournamentLength = 40;
        }

        public class Player
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 40;
            public const int MinAge = 16;
            public const int MaxAge = 70;
            public const double MinWeight = 40.0;
            public const double MaxWeight = 100.0;
            public const double MinHeight = 140.0;
            public const double MaxHeight = 240.0;
        }

        public class Location
        {
            public const int MinLocationLength = 2;
            public const int MaxLocationLength = 30;
        }

        public class Tournament
        {
            public const decimal MinPrize = 0m;
            public const decimal MaxPrize = decimal.MaxValue;
        }
        
        public class Title
        {
            public const int MinYear = 1900;
            public const int MaxYear = 2020;
        }
        
        public class Stats
        {
            public const int MinWin = 0;
            public const int MaxWin = 55;
            public const int MinLoss = 0;
            public const int MaxLoss = 55;
            public const int MinRank = 0;
            public const int MaxRank = 1000;
            public const int MinPoints = 0;
            public const int MaxPoints = 15000;
        }

        public class MatchResult
        {
            public const int MinPoints = 0;
            public const int MaxPoints = int.MaxValue;
        }
    }
}
