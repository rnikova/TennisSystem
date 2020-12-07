﻿using CarRentalSystem.Domain.Common;

namespace TennisSystem.Domain.Models.Tournaments
{
    public class Event : Enumeration
    {
        public static readonly Event ATP = new Event(1, nameof(ATP));
        public static readonly Event WTA = new Event(2, nameof(WTA));
        public static readonly Event Double = new Event(3, nameof(Double));
        public static readonly Event Mixed = new Event(3, nameof(Mixed));

        public Event(int value, string name) 
            : base(value, name)
        {
        }
    }
}