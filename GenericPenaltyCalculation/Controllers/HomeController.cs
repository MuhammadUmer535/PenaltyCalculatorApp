using GenericPenaltyCalculation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PenaltyCalculation.Core;
using PenaltyCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GenericPenaltyCalculation.Controllers
{
    public class HomeController : Controller
    {
        private readonly Country _country;
        private readonly PenaltyCalculator _calculator;

        public HomeController(Country country, PenaltyCalculator calculator)
        {
            _country = country;
            _calculator = calculator;

            if (_country.lstCountries == null)
                _country.GetCountries();
        }

        public IActionResult Index()
        {
            PenaltyCalculationModel pcModel = new PenaltyCalculationModel();

            pcModel.StartDate = DateTime.Now.Date;
            pcModel.EndDate = pcModel.StartDate.AddDays(1).Date;

            PreparePenaltyCalculationModel(pcModel);

            return View(pcModel);
        }

        [HttpPost]
        public IActionResult Index(PenaltyCalculationModel model)
        {
            var selectedCountry = _country.lstCountries.Where(c => c.Slug == model.selectedCountry).FirstOrDefault();

            var amount = _calculator.CalculatePenalty(model.StartDate, model.EndDate, selectedCountry);

            model.penaltyAmount = selectedCountry.Currency + " " + amount.ToString();

            PreparePenaltyCalculationModel(model);

            return View(model);
        }

        public PenaltyCalculationModel PreparePenaltyCalculationModel(PenaltyCalculationModel model) 
        {
            List<SelectListItem> Countries = new List<SelectListItem>();

            string result = RegionInfo.CurrentRegion.DisplayName;

            foreach (var country in _country.lstCountries)
            {
                Countries.Add(new SelectListItem() { Text = country.Name, Value = country.Slug, Selected = !string.IsNullOrEmpty(model.selectedCountry) ? country.Slug ==  model.selectedCountry : country.Name == result });
            }

            model.LstCountries = Countries;

            return model;
        }
    }
}
