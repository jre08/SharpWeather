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
   
    public class alerts
    {
        

        //public JToken description { get; set; }
        //public JToken date { get; set; }
        //public JToken date_epoch { get; set; }
        //public JToken expires { get; set; }
        //public JToken expires_epoch { get; set; }
        //public JToken message { get; set; }
        //public JToken phenomena { get; set; }
        //public JToken significance { get; set; }
        //public JToken tz_short { get; set; }
        //public JToken tz_long { get; set; }
        //public JToken StormBased { get; set; }

        public List<alert> alertList = new List<alert>();

        public alerts(string city)
        {
           
            try
            {
                var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/alerts/q/" + city + ".json");
                request.ContentType = "application/json";
                var response = (HttpWebResponse)request.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    Globals.alerts = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {


                Globals.alerts = File.ReadAllText(@"C:\API\alerts.txt");
            }
            
            //            var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/conditions/q/" + city + ".json");
            //            request.ContentType = "application/json";
            //            var response = (HttpWebResponse)request.GetResponse();
            //using (var sr = new StreamReader(response.GetResponseStream()))
            //            {
            //                Globals.forecast10 = sr.ReadToEnd();
            //            }
            //this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
            //this.period = (o["current_observation"]);

            //this.length = o["alerts"].HasValues;
            JObject o = JObject.Parse(Globals.alerts);
            
            
            System.Diagnostics.Debug.Print(o["alerts"].Any().ToString());
            
            
           	
           // System.Diagnostics.Debug.Print(jarr.Count().ToString());

           if (o["alerts"].Count() > 0 )
           {
           	JArray jarr = new JArray(o["alerts"]);
            if (jarr.Count != 0)
            {
                for (int i = 0; i < jarr.Count; i++)
                {

                    alert a = new SharpWeather.alert(i);
                    alertList.Add(a);
                }
                //this.description = (o["alerts"][num]["description"]);
                //this.date = (o["alerts"][num]["date"]);
                //this.date_epoch = (o["alerts"][num]["date_epoch"]);
                //this.expires = (o["alerts"][num]["expires"]);
                //this.expires_epoch = (o["alerts"][num]["expires_epoch"]);
                //this.message = (o["alerts"][num]["message"]);
                //this.phenomena = (o["alerts"][num]["phenomena"]);
                //this.significance = (o["alerts"][num]["significance"]);
                //this.tz_short = (o["alerts"][num]["tz_short"]);
                //this.tz_long = (o["alerts"][num]["tz_long"]);
                //this.StormBased = (o["alerts"][num]["StormBased"]);
                
            }

        }

    }
  }
    public class alert
    {
        JObject o = JObject.Parse(Globals.alerts);

        public JToken description { get; set; }
        public JToken date { get; set; }
        public JToken date_epoch { get; set; }
        public JToken expires { get; set; }
        public JToken expires_epoch { get; set; }
        public JToken message { get; set; }
        public JToken phenomena { get; set; }
        public JToken significance { get; set; }
        public JToken tz_short { get; set; }
        public JToken tz_long { get; set; }
        public JToken StormBased { get; set; }
        public JToken type { get; set; }



        public alert(int num)
        {
                this.type = (o["alerts"][num]["type"]);   
                this.description = (o["alerts"][num]["description"]);
                this.date = (o["alerts"][num]["date"]);
                this.date_epoch = (o["alerts"][num]["date_epoch"]);
                this.expires = (o["alerts"][num]["expires"]);
                this.expires_epoch = (o["alerts"][num]["expires_epoch"]);
                this.message = (o["alerts"][num]["message"]);
                this.phenomena = (o["alerts"][num]["phenomena"]);
                this.significance = (o["alerts"][num]["significance"]);
                this.tz_short = (o["alerts"][num]["tz_short"]);
                this.tz_long = (o["alerts"][num]["tz_long"]);
                this.StormBased = (o["alerts"][num]["StormBased"]);
            

        }

    }
}

   
       
         
     