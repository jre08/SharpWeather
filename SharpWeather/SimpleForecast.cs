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
    class SimpleForecast
    {
        public JToken period { get; set; }


        public JToken icon { get; set; }
        public JToken iconurl { get; set; }
        public JToken title { get; set; }
        public JToken fcstText { get; set; }
        public JToken precipChance { get; set; }


        public SimpleForecast(int num)
        {
            JObject o = JObject.Parse(Globals.forecast10);
            this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
            this.iconurl = (o["forecast"]["txt_forecast"]["forecastday"][num]["iconurl"]);
            this.icon = (o["forecast"]["txt_forecast"]["forecastday"][num]["icon"]);
            this.title = (o["forecast"]["txt_forecast"]["forecastday"][num]["title"]);
            this.fcstText = (o["forecast"]["txt_forecast"]["forecastday"][num]["fcttext"]);
            this.precipChance = (o["forecast"]["txt_forecast"]["forecastday"][num]["pop"]);
        }
    }
}
