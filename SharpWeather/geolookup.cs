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
    class geolookup
    {
        JObject o = JObject.Parse(Globals.geolookup);
        public JToken type { get; set; }

        public JToken country { get; set; }

        public JToken country_iso3166 { get; set; }

        public JToken country_name { get; set; }

        public JToken state { get; set; }

        public JToken city { get; set; }

        public JToken tz_short { get; set; }

        public JToken tz_long { get; set; }

        public JToken lat { get; set; }

        public JToken lon { get; set; }

        public JToken zip { get; set; }

        public JToken magic { get; set; }

        public JToken wmo { get; set; }

        public JToken l { get; set; }

        public JToken requesturl { get; set; }

        public JToken wuiurl { get; set; }


   
        
    }
}