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
    class almanac
    {
        JObject o = JObject.Parse(Globals.almanac);
        public JToken airport_code { get; set; }
        public JToken temp_high_normal_F { get; set; }
        public JToken temp_high_normal_C { get; set; }
        public JToken temp_high_record_F { get; set; }
        public JToken temp_high_record_C { get; set; }
        public JToken temp_high_recordyear { get; set; }
        public JToken temp_low_normal_F { get; set; }
        public JToken temp_low_normal_C { get; set; }
        public JToken temp_low_record_F { get; set; }
        public JToken temp_low_record_C { get; set; }
        public JToken temp_low_recordyear { get; set; }

        public almanac(string city, int num)
        {
            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/almanac/q/" + city + ".json");
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                Globals.forecast10 = sr.ReadToEnd();
            }
        }

    }
}
