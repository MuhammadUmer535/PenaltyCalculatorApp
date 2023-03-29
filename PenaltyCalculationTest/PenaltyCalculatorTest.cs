using NUnit.Framework;
using PenaltyCalculation.Core;
using PenaltyCalculationLibrary;
using System;
using System.Linq;

namespace PenaltyCalculationTest
{
    public class PenaltyCalculatorTests
    {
        private PenaltyCalculator _calculatorUtility;
        private Country _country;

        [SetUp]
        public void Setup()
        {
            _calculatorUtility = new PenaltyCalculator();
            _country = new Country();

            if (_country.lstCountries == null)
                _country.GetCountries();
        }

        [TestCase("3/29/2023 00:00:00", "3/31/2023 00:00:00", "US")]
        [TestCase("3/20/2023 00:00:00", "3/31/2023 00:00:00", "AE")]
        [TestCase("3/20/2023 00:00:00", "3/9/2023 00:00:00", "PK")]
        public void IsPenaltyCalculatedSuccessfully(string startDate, string endDate, string countrySlug)
        {
            DateTime dateStart = Convert.ToDateTime(startDate);
            DateTime dateEnd = Convert.ToDateTime(endDate);
            var country = _country.lstCountries.Where(c => c.Slug == countrySlug).FirstOrDefault();

            if (country != null)
            {
                var penaltyAmount = country.AmountPerDay * Utility.WorkDayBetween(dateStart, dateEnd, country);

                var result = _calculatorUtility.CalculatePenalty(dateStart, dateEnd, country);

                Assert.False(result != penaltyAmount);
            }
            else
            {
                Assert.Fail("Country not found.");
            }
        }  
    }
}