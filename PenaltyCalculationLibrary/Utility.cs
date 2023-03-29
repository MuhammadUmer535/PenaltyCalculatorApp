using PenaltyCalculation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculationLibrary
{
    public static class Utility
    {
        public static int WorkDayBetween(DateTime start, DateTime end, Country country)
        {
            return DaysBetween(start, end)
                .Where(date => IsWorkDay(date, country)).Count<DateTime>();
        }

        public static IEnumerable<DateTime> DaysBetween(DateTime start, DateTime end)
        {
            var current = start;
            if (current != current.Date)
                current = current.AddDays(1).Date;
            while (current < end)
            {
                yield return current;
                current = current.AddDays(1);
            }
        }

        private static bool IsWorkDay(DateTime date, Country country)
        {
            for(int i=0; i<country.DaysOff.Length; i++)
            {
                if (date.DayOfWeek == country.DaysOff[i])
                    return false;
            }

            return true;
        }
    }
}
