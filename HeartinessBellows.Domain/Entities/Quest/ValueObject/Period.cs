using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartinessBellows.Domain.Entities.Quest.ValueObject
{
    public record Period
    {
        public static readonly Period EveryDayQuest = new("daily",1);
        public static readonly Period EveryWeekQuest = new("weekly",7);
        public static readonly Period EveryMonthQuest = new("monthly",30);
        public static readonly Period EveryYearQuest = new("annual",360);


        private Period(string title, double multiplier) {
            Title = title;
            Multiplayer = multiplier;
        }
        
        public string Title { get; init; }
        public double Multiplayer { get; init; }
        public static readonly IReadOnlyCollection<Period> Periods = new[]
        {
            EveryDayQuest,
            EveryWeekQuest,
            EveryMonthQuest,
            EveryYearQuest
        };
    }
}
