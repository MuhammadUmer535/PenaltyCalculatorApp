using PenaltyCalculation.Core;
using System;
using System.Linq;

namespace PenaltyCalculationLibrary
{
    public class PenaltyCalculator
    {
        public double CalculatePenalty(DateTime dateStart, DateTime dateEnd, Country country)
        {
            double penaltyAmount = 0;

            penaltyAmount = country.AmountPerDay * Utility.WorkDayBetween(dateStart, dateEnd, country);

            return penaltyAmount;
        }
    }
}
