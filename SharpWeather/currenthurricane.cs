using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace SharpWeather
{
    class currenthurricane
    {
        JObject o = JObject.Parse(Globals.currentHurricane);
        public JToken stormName { get; set; }
        public JToken stormName_Nice { get; set; }
        public JToken stormNumber { get; set; }
        public JToken lat { get; set; }
        public JToken lon { get; set; }
        public JToken SaffirSimpsonCategory { get; set; }
        public JToken Category { get; set; }
        public JToken Time { get; set; }
        public JToken WindSpeed { get; set; }
        public JToken WindGust { get; set; }
        public JToken Fspeed { get; set; }
        public JToken Movement { get; set; }
        public JToken Movement_Degrees { get; set; }
        public JToken Movement_Text { get; set; }
        public JToken Pressure { get; set; }
        public JToken Pressure_mb { get; set; }
        public JToken Pressure_inches { get; set; }
        public JToken WindQuadrants { get; set; }
        public JToken WindRadius { get; set; }
        public JToken SeaQuadrants { get; set; }
        public JToken SeaRadius { get; set; }
        public JToken ForecastHour { get; set; }
        public JToken year { get; set; }
        public JToken mon { get; set; }
        public JToken mon_padded { get; set; }
        public JToken mon_abbrev { get; set; }
        public JToken mday { get; set; }
        public JToken mday_padded { get; set; }
        public JToken yday { get; set; }
        public JToken epoch { get; set; }
        public JToken pretty { get; set; }
        public JToken civil { get; set; }
        public JToken month_name { get; set; }
        public JToken month_name_abbrev { get; set; }
        public JToken weekday_name { get; set; }
        public JToken weekday_name_night { get; set; }
        public JToken weekday_name_abbrev { get; set; }
        public JToken weekday_name_unlang { get; set; }
        public JToken weekday_name_night_unlang { get; set; }
        public JToken ampm { get; set; }

        public currenthurricane(string city, int num)
        {
            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/currenhurricane/q/" + city + ".json");
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                Globals.forecast10 = sr.ReadToEnd();
            }

        }
    }
}
