using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public class Weather
    {
        public int ImageNr { get; set; }
        public DateTime Today { get; set; }
        public decimal Temperature { get; set; }
        public string ImageUrl { get; set; }

        //public void SetWeather(string nr, string temp)
        //{
        //    ImageNr = Int32.Parse(nr);
        //    Temperature = Int32.Parse(temp);
        //}
    }
}
