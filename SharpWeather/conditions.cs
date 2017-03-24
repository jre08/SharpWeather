using System;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace SharpWeather
{
    //    //url  = http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/CA/San_Francisco.json

    class conditions
    {
        

        public JToken image_url { get; set; }
        public JToken image_title { get; set; }
        public JToken image_link { get; set; }
        public JToken display_location_full { get; set; }
        public JToken display_location_city { get; set; }
        public JToken display_location_state { get; set; }
        public JToken display_location_state_name { get; set; }
        public JToken display_location_country { get; set; }
        public JToken display_location_country_iso3166 { get; set; }
        public JToken display_location_zip { get; set; }
        public JToken display_location_latitude { get; set; }
        public JToken display_location_longitude { get; set; }
        public JToken display_location_elevation { get; set; }
        public JToken observation_location_full { get; set; }
        public JToken observation_location_city { get; set; }
        public JToken observation_location_state { get; set; }
        public JToken observation_location_country { get; set; }
        public JToken observation_location_country_iso3166 { get; set; }
        public JToken observation_location_latitude { get; set; }
        public JToken observation_location_longitude { get; set; }
        public JToken observation_location_elevation { get; set; }
        public JToken estimated { get; set; }
        public JToken station_id { get; set; }
        public JToken observation_time { get; set; }
        public JToken observation_time_rfc822 { get; set; }
        public JToken observation_epoch { get; set; }
        public JToken local_time_rfc822 { get; set; }
        public JToken local_epoch { get; set; }
        public JToken local_tz_short { get; set; }
        public JToken local_tz_long { get; set; }
        public JToken local_tz_offset { get; set; }
        public JToken weather { get; set; }
        public JToken temperature_string { get; set; }
        public JToken temp_f { get; set; }
        public JToken temp_c { get; set; }
        public JToken relative_humidity { get; set; }
        public JToken wind_string { get; set; }
        public JToken wind_dir { get; set; }
        public JToken wind_degrees { get; set; }
        public JToken wind_mph { get; set; }
        public JToken wind_gust_mph { get; set; }
        public JToken wind_kph { get; set; }
        public JToken wind_gust_kph { get; set; }
        public JToken pressure_mb { get; set; }
        public JToken pressure_in { get; set; }
        public JToken pressure_trend { get; set; }
        public JToken dewpoint_string { get; set; }
        public JToken dewpoint_f { get; set; }
        public JToken dewpoint_c { get; set; }
        public JToken heat_index_string { get; set; }
        public JToken heat_index_f { get; set; }
        public JToken heat_index_c { get; set; }
        public JToken windchill_string { get; set; }
        public JToken windchill_f { get; set; }
        public JToken windchill_c { get; set; }
        public JToken feelslike_string { get; set; }
        public JToken feelslike_f { get; set; }
        public JToken feelslike_c { get; set; }
        public JToken visibility_mi { get; set; }
        public JToken visibility_km { get; set; }
        public JToken solarradiation { get; set; }
        public JToken UV { get; set; }
        public JToken precip_1hr_string { get; set; }
        public JToken precip_1hr_in { get; set; }
        public JToken precip_1hr_metric { get; set; }
        public JToken precip_today_string { get; set; }
        public JToken precip_today_in { get; set; }
        public JToken precip_today_metric { get; set; }
        public JToken icon { get; set; }
        public JToken icon_url { get; set; }
        public JToken forecast_url { get; set; }
        public JToken history_url { get; set; }
        public JToken ob_url { get; set; }
       

        public conditions(int num)
        {


            if (Globals.conditions == "")
            {

                try
                {
                    var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + Globals.zipCity + ".json");
                    request.ContentType = "application/json";
                    var response = (HttpWebResponse)request.GetResponse();

                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        Globals.conditions = sr.ReadToEnd();

                    }
                }
                catch (Exception)
                {

                    Globals.conditions = File.ReadAllText(@"C:\API\conditions.txt"); ;
                }
                //*********
                //Used to set Global 10 day forcast using a txt file
                //*********
                //Globals.conditions = File.ReadAllText(@"C:\API\conditions.txt");

                //*******
                //Used to set Global 10 day forcast using Weather Underground Website API
                //*******    

                
            }
            JObject o = JObject.Parse(Globals.conditions);

            this.image_url = (o["current_observation"]["image"]["url"]);
            this.image_title = (o["current_observation"]["image"]["title"]);
            this.image_link = (o["current_observation"]["image"]["link"]);


            this.display_location_full = (o["current_observation"]["display_location"]["full"]);
            this.display_location_city = (o["current_observation"]["display_location"]["city"]);
            this.display_location_state = (o["current_observation"]["display_location"]["state"]);
            this.display_location_state_name = (o["current_observation"]["display_location"]["state_name"]);
            this.display_location_country = (o["current_observation"]["display_location"]["country"]);
            this.display_location_country_iso3166 = (o["current_observation"]["display_location"]["country_iso3166"]);
            this.display_location_zip = (o["current_observation"]["display_location"]["zip"]);
            this.display_location_latitude = (o["current_observation"]["display_location"]["latitude"]);
            this.display_location_longitude = (o["current_observation"]["display_location"]["longitude"]);
            this.display_location_elevation = (o["current_observation"]["display_location"]["elevation"]);

            this.observation_location_full = (o["current_observation"]["observation_location"]["full"]);
            this.observation_location_city = (o["current_observation"]["observation_location"]["city"]);
            this.observation_location_state = (o["current_observation"]["observation_location"]["state"]);
            this.observation_location_country = (o["current_observation"]["observation_location"]["country"]);
            this.observation_location_country_iso3166 = (o["current_observation"]["observation_location"]["country_iso3166"]);
            this.observation_location_latitude = (o["current_observation"]["observation_location"]["latitude"]);
            this.observation_location_longitude = (o["current_observation"]["observation_location"]["longitude"]);
            this.observation_location_elevation = (o["current_observation"]["observation_location"]["elevation"]);

            //			this.estimated =

            this.station_id = (o["current_observation"]["station_id"]);
            this.observation_time = (o["current_observation"]["observation_time"]);
            this.observation_time_rfc822 = (o["current_observation"]["observation_time_rfc822"]);
            this.observation_epoch = (o["current_observation"]["epoch"]);
            this.local_time_rfc822 = (o["current_observation"]["local_time_rfc822"]);
            this.local_epoch = (o["current_observation"]["local_epoch"]);
            this.local_tz_short = (o["current_observation"]["local_tz_short"]);
            this.local_tz_long = (o["current_observation"]["local_tz_long"]);
            this.local_tz_offset = (o["current_observation"]["local_tz_offset"]);
            this.weather = (o["current_observation"]["weather"]);
            this.temperature_string = (o["current_observation"]["temperature_string"]);
            this.temp_f = (o["current_observation"]["temp_f"]);
            this.temp_c = (o["current_observation"]["temp_c"]);
            this.relative_humidity = (o["current_observation"]["relative_humidity"]);
            this.wind_string = (o["current_observation"]["wind_string"]);
            this.wind_dir = (o["current_observation"]["wind_dir"]);
            this.wind_degrees = (o["current_observation"]["wind_degrees"]);
            this.wind_mph = (o["current_observation"]["wind_mph"]);
            this.wind_gust_mph = (o["current_observation"]["wind_gust_mph"]);
            this.wind_kph = (o["current_observation"]["wind_kph"]);
            this.wind_gust_kph = (o["current_observation"]["wind_gust_kph"]);
            this.pressure_mb = (o["current_observation"]["pressure_mb"]);
            this.pressure_in = (o["current_observation"]["pressure_in"]);
            this.pressure_trend = (o["current_observation"]["pressure_trend"]);
            this.dewpoint_string = (o["current_observation"]["dewpoint_string"]);
            this.dewpoint_f = (o["current_observation"]["dewpoint_f"]);
            this.dewpoint_c = (o["current_observation"]["dewpoint_c"]);
            this.heat_index_string = (o["current_observation"]["heat_index_string"]);
            this.heat_index_f = (o["current_observation"]["heat_index_f"]);
            this.heat_index_c = (o["current_observation"]["heat_index_c"]);
            this.windchill_string = (o["current_observation"]["windchill_string"]);
            this.windchill_f = (o["current_observation"]["windchill_f"]);
            this.windchill_c = (o["current_observation"]["windchill_c"]);
            this.feelslike_string = (o["current_observation"]["feelslike_string"]);
            this.feelslike_f = (o["current_observation"]["feelslike_f"]);
            this.feelslike_c = (o["current_observation"]["feelslike_c"]);
            this.visibility_mi = (o["current_observation"]["visibility_mi"]);
            this.visibility_km = (o["current_observation"]["visibility_km"]);
            this.solarradiation = (o["current_observation"]["solarradiation"]);
            this.UV = (o["current_observation"]["UV"]);
            this.precip_1hr_string = (o["current_observation"]["precip_1hr_string"]);
            this.precip_1hr_in = (o["current_observation"]["precip_1hr_in"]);
            this.precip_1hr_metric = (o["current_observation"]["precip_1hr_metric"]);
            this.precip_today_string = (o["current_observation"]["precip_today_string"]);
            this.precip_today_in = (o["current_observation"]["precip_today_in"]);
            this.precip_today_metric = (o["current_observation"]["precip_today_metric"]);
            this.icon = (o["current_observation"]["icon"]);
            this.icon_url = (o["current_observation"]["icon_url"]);
            this.forecast_url = (o["current_observation"]["forecast_url"]);
            this.history_url = (o["current_observation"]["history_url"]);
            this.ob_url = (o["current_observation"]["ob_url"]);

            this.bg_image = BG_Image(this.icon.ToString(),"Day");

        }
        public Image bg_image { get; set; }
        public Image BG_Image(string name, string tme)

        {
            
            Random r = new Random();
            int num = r.Next(1, 5);
            if (tme == "night")
            {
                switch (name)
                {

                    case "chanceflurries":
                        return weatherIcons.ChanceFlurries;
                    case "chancerain":
                        return weatherIcons.ChanceRain;
                    case "chancesleet":
                        return weatherIcons.Sleet;
                    case "chancesnow":
                        return weatherIcons.ChanceSnow;
                    case "chancetstorms":
                        return weatherIcons.ChanceTstorm;
                    case "cloudy":
                        return weatherIcons.Cloudy;
                    case "flurries":
                        return weatherIcons.Flurries;
                    case "fog":
                        return weatherIcons.Fog;
                    case "hazy":
                        return weatherIcons.Hazy;
                    case "mostlycloudy":
                        return weatherIcons.MostlyCloudy;
                    case "partlycloudy":
                        return weatherIcons.PartlyCloudy;
                    case "sleet":
                        return weatherIcons.Sleet;
                    case "rain":
                        return weatherIcons.Rain;
                    case "snow":
                        return weatherIcons.Snow;
                    case "sunny":
                        return weatherIcons.Sunny;
                    case "tstorms":
                        return weatherIcons.ThunderStorms;
                    case "clear":
                        return weatherIcons.ClearNight;
                    default:
                        return null;

                }

            }
            else
            {
                switch (name)
                {

                    case "chanceflurries":
                        return weatherIcons.ChanceFlurries;
                    case "chancerain":
                        return weatherIcons.ChanceRain;
                    case "chancesleet":
                        return weatherIcons.Sleet;
                    case "chancesnow":
                        return weatherIcons.ChanceSnow;
                    case "chancetstorms":
                        return weatherIcons.ChanceTstorm;
                    case "cloudy":
                        return weatherIcons.Cloudy_1;
                    case "flurries":
                        return weatherIcons.Flurries;
                    case "fog":
                        return weatherIcons.Fog;
                    case "hazy":
                        return weatherIcons.Hazy;
                    case "mostlycloudy":
                        return weatherIcons.MostlyCloudy_1;
                    case "partlycloudy":

                        if (num == 1)
                        {
                            return weatherIcons.PartlyCloudy_1;
                        }
                        else if (num == 2)
                        {
                            return weatherIcons.PartlyCloudy_2;
                        }
                        else if (num == 3)
                        {
                            return weatherIcons.PartlyCloudy_1;
                        }
                        else if (num == 4)
                        {
                            return weatherIcons.PartlyCloudy_2;
                        }
                        else if (num == 5)
                        {
                            return weatherIcons.PartlyCloudy_1;
                        }
                        else
                            return null;
                    case "sleet":
                        return weatherIcons.Sleet;
                    case "rain":
                        return weatherIcons.Rain;
                    case "snow":
                        return weatherIcons.Snow;
                    case "sunny":
                        return weatherIcons.Sunny;
                    case "tstorms":
                        return weatherIcons.ThunderStorms;
                    case "clear":
                        if (num==1)
                        {
                            return weatherIcons.Clear_1;
                        }
                        else if (num==2)
                        {
                            return weatherIcons.Clear_2;
                        }
                        else if (num == 3)
                        {
                            return weatherIcons.Clear_3;
                        }
                        else if (num == 4)
                        {
                            return weatherIcons.Clear_4;
                        }
                        else if (num == 5)
                        {
                            return weatherIcons.Clear_5;
                        }
                        else if (num == 6)
                        {
                            return weatherIcons.Clear_6;
                        }
                        return null;


                    default:
                        break;
                }
                return null;

            }
        }
    }

}
