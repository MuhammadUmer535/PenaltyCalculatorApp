using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PenaltyCalculation.Core
{
    public class Country
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Currency { get; set; }

        public double AmountPerDay { get; set; }

        public DayOfWeek[] DaysOff { get; set; }

        public List<Country> lstCountries;

        public void GetCountries()
        {
            using (StreamReader r = new StreamReader("countryData.json"))
            {
                string json = r.ReadToEnd();
                lstCountries = JsonSerializer.Deserialize<List<Country>>(json);
            }
        }
    }
}
