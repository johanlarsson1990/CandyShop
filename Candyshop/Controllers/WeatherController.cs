using Candyshop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            //GetWeather();
            //var url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json";
            //var weather = new Weather
            //{
            //    Today = DateTime.Now,
            //    ImageNr = 0,
            //    ImageUrl = "",
            //    Temperature = 0.0M
            //};
            return View();
        }

        [HttpGet]
        public ActionResult GetWeather()
        {
            var url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json";
            Console.WriteLine(url);
            return null;
        }
    }
    

}
