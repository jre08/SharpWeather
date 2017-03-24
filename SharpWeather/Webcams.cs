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
    class Webcams
    {

        public JToken handle { get; set; }
        public JToken camid { get; set; }
        public JToken camindex { get; set; }
        public JToken assoc_station_id { get; set; }
        public JToken link { get; set; }
        public JToken linktext { get; set; }
        public JToken cameratype { get; set; }
        public JToken organization { get; set; }
        public JToken neighborhood { get; set; }
        public JToken zip { get; set; }
        public JToken city { get; set; }
        public JToken state { get; set; }
        public JToken country { get; set; }
        public JToken tzname { get; set; }
        public JToken lat { get; set; }
        public JToken lon { get; set; }
        public JToken updated { get; set; }
        public JToken downloaded { get; set; }
        public JToken isrecent { get; set; }
        public JToken CURRENTIMAGEURL { get; set; }
        public JToken WIDGETCURRENTIMAGEURL { get; set; }
        public JToken CAMURL { get; set; }
    }
}
