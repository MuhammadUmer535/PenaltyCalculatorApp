using Microsoft.AspNetCore.Mvc.Rendering;
using PenaltyCalculation.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenericPenaltyCalculation.Models
{
    public class PenaltyCalculationModel
    {
        public PenaltyCalculationModel()
        {
            LstCountries = new List<SelectListItem>();
        }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }


        public List<SelectListItem> LstCountries;

        public string selectedCountry { get; set; }

        public string penaltyAmount { get; set; }
    }
}
