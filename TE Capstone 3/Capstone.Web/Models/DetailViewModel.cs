using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class DetailViewModel
    {
        public Park ParkDetail { get; set; }
        public IList<Forecast> Forecasts { get; set; }
        public string TemperatureUnit { get; set; }

        public DetailViewModel(Park park, IList<Forecast> forecasts, string temperatureUnit)
        {
            this.ParkDetail = park;
            this.Forecasts = forecasts;
            this.TemperatureUnit = temperatureUnit;
        }
    }
}
