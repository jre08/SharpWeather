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
    public class forecast10
    {


        
        //txt_forecast
        //public JToken period { get; set; }


        public JToken icon { get; set; }
        //public JToken iconurl { get; set; }
        //public JToken title { get; set; }
        //public JToken fcstText { get; set; }
        //public JToken precipChance { get; set; }

        public JToken day { get; set; }
        public JToken month { get; set; }
        public JToken year { get; set; }
        public JToken monthname { get; set; }
        public JToken weekday_short { get; set; }
        public JToken weekday { get; set; }
        public JToken ampm { get; set; }
        public JToken tz_short { get; set; }
        public JToken tz_long { get; set; }

        public JToken fahrenheitHi { get; set; }
        public JToken fahrenheitLow { get; set; }
        public JToken celsiusHi { get; set; }
        public JToken celsiusLow { get; set; }

        public JToken conditions { get; set; }
        public JToken iconURL { get; set; }
        public JToken skyIcon { get; set; }
        public JToken rainInch { get; set; }
        public JToken rainMM { get; set; }
        public JToken snowInch { get; set; }
        public JToken snowMM { get; set; }
        public JToken maxWindmph { get; set; }
        public JToken maxWindkph { get; set; }
        public JToken maxWinddir { get; set; }
        public JToken maxWinddegrees { get; set; }
        public JToken avgWindmph { get; set; }
        public JToken avgWindkph { get; set; }
        public JToken avgWinddir { get; set; }
        public JToken avgWinddegrees { get; set; }
        public JToken avgHumidity { get; set; }
        public JToken maxHumidity { get; set; }
        public JToken minHumidity { get; set; }

        public forecast10(int num)
        {
            if (Globals.forecast10 == "")
            {
                try
                {
                    var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/forecast10day/q/" + Globals.zipCity + ".json");
                    request.ContentType = "application/json";
                    var response = (HttpWebResponse)request.GetResponse();

                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        Globals.forecast10 = sr.ReadToEnd();

                    }
                }
                catch (Exception)
                {

                    Globals.forecast10 = File.ReadAllText(@"C:\API\forecast10day.txt");
                }
                //Used to set Global 10 day forcast using a txt file
                //
                //Globals.forecast10 = File.ReadAllText(@"C:\API\forecast10day.txt");
                //Globals.forecast10 = 
                
                //
                //Used to set Global 10 day forcast using Weather Underground Website API
                //    

                
            }
            JObject o10day = JObject.Parse(Globals.forecast10);

            //text forecast
            //this.period = (o10day["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
            //this.iconurl = (o10day["forecast"]["txt_forecast"]["forecastday"][num]["iconurl"]);
            //this.title = (o10day["forecast"]["txt_forecast"]["forecastday"][num]["title"]);
            //this.fcstText = (o10day["forecast"]["txt_forecast"]["forecastday"][num]["fcttext"]);
            //this.precipChance = (o10day["forecast"]["txt_forecast"]["forecastday"][num]["pop"]);


            //simeple forecast (extended) 

            //Date
            this.day = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["day"]);
            this.month = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["month"]);
            this.year = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["year"]);
            this.monthname = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["monthname"]);
            this.weekday_short = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["weekday_short"]);
            this.weekday = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["weekday"]);
            this.ampm = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["ampm"]);
            this.tz_short = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["tz_short"]);
            this.tz_long = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["date"]["tz_long"]);


            //Weather
            this.fahrenheitHi = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["high"]["fahrenheit"]);
            this.fahrenheitLow = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["low"]["fahrenheit"]);
            this.celsiusHi = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["high"]["celsius"]);
            this.celsiusLow = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["low"]["celsius"]);

            this.conditions = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["conditions"]);
            this.icon = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["icon"]);
            this.iconURL = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["iconURL"]);
            this.skyIcon = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["skyicon"]);
            this.maxWindmph = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["mph"]);
            this.maxWindkph = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["kph"]);
            this.maxWinddir = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["dir"]);
            this.maxWinddegrees = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["degrees"]);
            this.maxHumidity = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["maxhumidity"]);

            this.avgWindmph = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["mph"]);
            this.avgWindkph = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["kph"]);
            this.avgWinddir = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["dir"]);
            this.avgWinddegrees = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["degrees"]);
            this.avgHumidity = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["avehumidity"]);

            this.minHumidity = (o10day["forecast"]["simpleforecast"]["forecastday"][num]["minhumidity"]);

        }


    }
}
