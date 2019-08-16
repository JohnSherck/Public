using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;
using Microsoft.AspNetCore.Http;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private IParkDAO parkDAO;
        private ISurveyResultDAO surveyDAO;

        public HomeController(IParkDAO parkDAO, ISurveyResultDAO surveyDAO)
        {
            this.parkDAO = parkDAO;
            this.surveyDAO = surveyDAO;
        }

        public IActionResult Index()
        {
            IList<Park> parks = parkDAO.GetParks();
            return View(parks);
        }

        public IActionResult Detail(string id)
        {
            Park park = parkDAO.GetParkByCode(id);
            IList<Forecast> forecasts = parkDAO.GetFiveDay(id);
            string tempUnit = GetPreferredUnit();
            return View(new DetailViewModel(park, forecasts, tempUnit));
        }

        [HttpGet]
        public IActionResult Survey()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Survey(SurveyResult result)
        {
            if(!ModelState.IsValid)
            {
                return View("Survey");
            }
            surveyDAO.SaveSurveyResult(result);
            return RedirectToAction("FavoriteParks");
        }

        [HttpGet]
        public IActionResult FavoriteParks()
        {
            IList<FavoriteParksVM> vm = surveyDAO.GetFavoriteParks();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Preferences()
        {
            Preferences pref = new Preferences()
            {
                TemperatureUnit = GetPreferredUnit()
            };
            return View(pref);
        }

        [HttpPost]
        public IActionResult Preferences(Preferences pref)
        {
            SetPreferredUnit(pref.TemperatureUnit);
            return RedirectToAction("Index", "Home");
        }

        private string GetPreferredUnit()
        {
            return HttpContext.Session.GetString("PreferredUnit") ?? "";
        }

        private void SetPreferredUnit(string unit)
        {
            if (unit == null || unit.Trim().Length == 0)
            {
                ClearPreferredUnit();
            }
            else
            {
                HttpContext.Session.SetString("PreferredUnit", unit);
            }
        }

        private void ClearPreferredUnit()
        {
            HttpContext.Session.Remove("PreferredUnit");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
