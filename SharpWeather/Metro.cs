using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using SharpWeather;
using Sharp_Weather;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;


namespace SharpWeather
{
	public partial class Metro : Form
    {
        public Metro()
        {
            InitializeComponent();
        }

        public void Forecast10day()
        {
            //JObject o = JObject.Parse(textjson);
            
            //forecast10 Day1 = new forecast10(0);
            //forecast10 Night1 = new forecast10(1);



            //STOP HERE   ***  working on getting the forcast4 class structure correct so that there is a daycast subclass of forecast for each day
            //picpath = weather1.readJson(0, "icon_url");
            // Debug.Print((string)weather1.icon);
        //    //picboxD1.Image = SharpWeather.weatherIcon((string)Day1.icon, "Day");
        //    lblD1.Text = (string)Day1.title;
        //    d1Hi.Text = (string)Day1.fahrenheitHi;
        //    d1Low.Text = (string)Day1.fahrenheitLow;
        //    //lblD1desc.Text = weather.fcstText;
        //    lblD1pop.Text = "Chance of precipitation: " + Day1.precipChance;
        }

        private void Metro_Load(object sender, EventArgs e)
        {
        //    Forecast10day();
        //    gMap.SetPositionByKeywords("Tallahassee, FL");
        //    //statusbarMapZoom.Text = String.Format("Map Zoom Level = {0}", gMap.Zoom);
        //    GMapProvider provider = GMapProviders.BingHybridMap;
        //    gMap.MapProvider = provider;
        }

        private void gMap_OnMapZoomChanged()
        {

        }
    }
}
