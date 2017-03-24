using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpWeather;
using MetroFramework.Forms;
//
// Created by SharpDevelop.
// User: edenfield-john
// Date: 10/6/2015
// Time: 4:10 PM
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//

//Option Explicit On
using System.Xml.Linq;


public partial class MainForm : Form
{
    conditions CurrentConditions = new conditions(1);


    forecast10 Day1 = new forecast10(0);
    forecast10 Night1 = new forecast10(1);

    forecast10 Day2 = new forecast10(2);
    forecast10 Night2 = new forecast10(3);

    forecast10 Day3 = new forecast10(4);
    forecast10 Night3 = new forecast10(5);

    forecast10 Day4 = new forecast10(6);
    forecast10 Night4 = new forecast10(7);

    forecast10 Day5 = new forecast10(8);
    forecast10 Night5 = new forecast10(9);

    SimpleForecast simple2 = new SimpleForecast(2);
    SimpleForecast simple3 = new SimpleForecast(4);
    SimpleForecast simple4 = new SimpleForecast(6);


    alerts Alerts = new alerts("32443");
    
    WeatherMap Map = new WeatherMap();

    //forecast10 Day6 = new forecast10(10);
    //forecast10 Night6 = new forecast10(11);

    //forecast10 Day7 = new forecast10(12);
    //forecast10 Night7 = new forecast10(13);

    //forecast10 Day8 = new forecast10(14);
    //forecast10 Night8 = new forecast10(15);

    //forecast10 Day9 = new forecast10(16);
    //forecast10 Night9 = new forecast10(17);

    //forecast10 Day10 = new forecast10(18);
    //forecast10 Night10 = new forecast10(19);


    //PointLatLng gtl = new PointLatLng(50, -129);
    //PointLatLng gbr = new PointLatLng(21.652538062803, -66.517937876818);

    public MainForm()
    {
        //SizeChanged += Redrawmap;
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
        //

        //I read the JSON file in the Class File
        //readJson("32460");
        //readJson("32460", "forecast10day");
        //readJson("32460", "conditions");
       
        for (int i = 0; i < Alerts.alertList.Count; i++)
        {
            txtbox_debug_debug.Text += String.Format("{0}\n", Alerts.alertList[i].message);
        }

        Conditions();
        Forecast10day();
        alertInt();
        //radialGauge1.Value = float.Parse(CurrentConditions.temp_f.ToString());
        //forecast10day();
        //GMapLoad();

        this.tabPageConditions.Controls.Add(Map);
        Map.Top =  3;
        Map.Left = 562;
		this.Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        

    }
    
    
    


    public void alertInt()
    {
        foreach (alert item in Alerts.alertList)
        {
            ListViewItem lvitem = new ListViewItem(new string[] {
            item.description.ToString()}, alertimg(item.type.ToString()), System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            lvitem.ToolTipText = item.message.ToString();
            Alert_listview.Items.Add(lvitem);


            AlertControl AC = new AlertControl();
            AC.alertType.Text = item.description.ToString();
            AC.alertImg.Image = alertImgLst.Images[alertimg(item.type.ToString())];
            AC.alertMsg.Text = item.message.ToString();

            this.alertPanel.Controls.Add(AC);
            AC.Location = new System.Drawing.Point(1,1);
        }
    }

    public int alertimg(string desc)
    {
        switch (desc)
        {
            case "HUR":
            //Hurricane 
            case "TOR":
                // Tornado Warning
            case "TOW":
            // Tornado Watch
            case "WRN":
            // Severe Thunderstorm Warning
            case "SEW":
            // Severe Thunderstorm Watch
            case "WIN":
            // Winter Weather Advisory
            case "FLO":
            // Flood Warning
            case "WAT":
            // Flood Watch / Statement 
            case "WND":
            // High Wind Advisory
            case "SVR":
            // Severe Weather Statement 
            case "HEA":
            // Heat Advisory 
                return 1;
            case "FOG":
            // Dense Fog Advisory 
            case "SPE":
            // Special Weather Statement 
            case "FIR":
            // Fire Weather Advisory 
            case "VOL":
            // Volcanic Activity Statement
            default:
                return 0;

        }
    }
    public Image weatherIcon(string name, string tme)

    {
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
                    return weatherIcons.ClearDay;


                default:
                    break;
            }
            return null;

        }
    }

    private void comboBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            //zipcode zip = new zipcode(zipBox.Text);
            zipBox.Items.Clear();
            zipcode(zipBox.Text);
        }
    }

    private void zipBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        string city = zipBox.Text;
        Debug.Print(city);
        city = city.Substring(city.Length - 5, 5);
        readJson(city);
        Forecast10day();
        //forecast10day();


    }


    public void Forecast10day()
    {

        day1Label.Text = String.Format("{0}", Day1.day);
        day1Desc.Text = String.Format("{0}", Day1.conditions);
        //tabPage10Day.BackgroundImage = tabPageConditions.BackgroundImage;
        panel2.BackgroundImage = tabPageConditions.BackgroundImage;
        
        metroTabPage4.BackgroundImage = tabPageConditions.BackgroundImage;
        
        //STOP HERE   ***  working on getting the forcast4 class structure correct so that there is a daycast subclass of forecast for each day
        //picpath = weather1.readJson(0, "icon_url");
        // Debug.Print((string)weather1.icon);
        //picbox_conditions_icon.Image = weatherIcon((string)Day1.icon, "Day");
        //lbl_Condition_Day.Text = (string)Day1.title;
        //lbl_Condition_Weather.Text = (string)Day1.fahrenheitHi;
        //lbl_Condition_temp.Text = (string)Day1.fahrenheitLow;
        //lblD1desc.Text = weather.fcstText;
        //lbl_Condition_wind.Text = "Chance of precipitation: " + Day1.precipChance;

        //picboxN1.Image = weatherIcon((string)Night1.icon, "Night");
        //lbl_Condition_dewpoint.Text = (string)Night1.title;
        //lbl_Condition_pressure_mb.Text = (string)Night1.fahrenheitHi;
        //lbl_Condition_pressure_trend.Text = (string)Night1.fahrenheitLow;
        //lblN1desc.Text = weather.readJson(1,"fcttext");
        //lbl_Condition_feels.Text = "Chance of precipitation: " + Convert.ToString(Night1.precipChance);



        // picboxD2.Image = weatherIcon((string)Day2.icon, "Day");
        //lblD2.Text = (string)Day2.title;
        ////lblD2desc.Text = weather.readJson(2,"fcttext");
        //lblD2pop.Text = "Chance of precipitation: " + Convert.ToString(Day2.precipChance);

        ////picpath = Convert.ToString(weather1.iconURL);
        ////picboxN2.Image = weatherIcon((string)Night2.icon, "Night");
        //lblN2.Text = Convert.ToString(Night2.title);
        ////lblN2desc.Text = weather.readJson(3,"fcttext");
        //lblN2pop.Text = "Chance of precipitation: " + Convert.ToString(Night2.precipChance);



        //picpath = weather1.readJson(4, "icon_url");
        //picboxD3.Load(picpath);
        //lblD3.Text = weather1.readJson(4, "title");
        ////lblD3desc.Text = weather.readJson(4,"fcttext");
        //lblD3pop.Text = "Chance of precipitation: " + weather1.readJson(4, "pop");

        //picpath = weather1.readJson(5, "icon_url");
        //picboxN3.Load(picpath);
        //lblN3.Text = weather1.readJson(5, "title");
        ////lblN3desc.Text = weather.readJson(5,"fcttext");
        //lblN3pop.Text = "Chance of precipitation: " + weather1.readJson(5, "pop");



        //picpath = weather1.readJson(6, "icon_url");
        //picboxD4.Image = weatherIcon((string)Day4.icon, "Day");
        //lblD4.Text = weather1.readJson(6, "title");
        ////lblD4desc.Text = weather.readJson(6,"fcttext");
        //lblD4pop.Text = "Chance of precipitation: " + weather1.readJson(6, "pop");

        //picpath = weather1.readJson(7, "icon_url");
        //Debug.Print((string)Night4.icon);
        //picboxN4.Image = weatherIcon((string)Night4.icon, "Night");
        //lblN4.Text = weather1.readJson(7, "title");
        ////lblN4desc.Text = weather.readJson(7,"fcttext");
        //lblN4pop.Text = "Chance of precipitation: " + weather1.readJson(7, "pop");



        //weather1 = null;
        /*
		string xUrl = "http://api.wunderground.com/api/8390d409d9f2d532/forecast/q/FL/Tallahassee.xml";
		XmlDocument xInfo = new XmlDocument();
		xInfo.Load(xUrl);
		XmlNodeList nodes1 = default(XmlNodeList);
		string picpath = null;

		#region "Way to add controls in a list"
		//Private _userControlList As New List(Of YourControl)

		//Private Sub AddingControlOnPanel()
		//   Dim index As Integer = _userControlList.Count + 1
		//  Dim userControl As New YourControl
		// UserControl.Location = New System.Drawing.Point(SomeLocation)
		//UserControl.Size = New System.Drawing.Size(SomeSize)
		//UserControl.Name = "userControl" + index.ToString
		//UserControl.Visible = False
		//_userControlList.Add(userControl)
		//UserControlsPanel.Controls.Add(userControl)
		//UserControl.Visible = True
		//End Sub
		#endregion

		#region "4 day Forecast"
		//Day one
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=1]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD1.Load(picpath);
		lblD1.Text = nodes1.Item(3).InnerText;
		lblD1desc.Text = nodes1.Item(4).InnerText;
		lblD1pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//Night one
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=2]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN1.Load(picpath);
		lblN1.Text = nodes1.Item(3).InnerText;
		lblN1desc.Text = nodes1.Item(4).InnerText;
		lblN1pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day two
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=3]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD2.Load(picpath);
		lblD2.Text = nodes1.Item(3).InnerText;
		lblD2desc.Text = nodes1.Item(4).InnerText;
		lblD2pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night two
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=4]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN2.Load(picpath);
		lblN2.Text = nodes1.Item(3).InnerText;
		lblN2desc.Text = nodes1.Item(4).InnerText;
		lblN2pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day three
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=5]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD3.Load(picpath);
		lblD3.Text = nodes1.Item(3).InnerText;
		lblD3desc.Text = nodes1.Item(4).InnerText;
		lblD3pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night three
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=6]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN3.Load(picpath);
		lblN3.Text = nodes1.Item(3).InnerText;
		lblN3desc.Text = nodes1.Item(4).InnerText;
		lblN3pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day four
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=7]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD4.Load(picpath);
		lblD4.Text = nodes1.Item(3).InnerText;
		lblD4desc.Text = nodes1.Item(4).InnerText;
		lblD4pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night Four
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=8]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN4.Load(picpath);
		lblN4.Text = nodes1.Item(3).InnerText;
		lblN4desc.Text = nodes1.Item(4).InnerText;
		lblN4pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;
		//RichTextBox1.Text = text2
		#endregion
	}

	private void Button1_Click(object sender, EventArgs e)
	{	
		/*
		Controls.Remove(tabControl1);
		//_10DayForecast day10 = new _10DayForecast();
		day10.Location = new System.Drawing.Point(12, 12);
		day10.Size = new System.Drawing.Size(1007, 527);
		Controls.Add(day10);
		this.Controls.Add(day10);
		day10.Visible = true;
*/
    }

    /// <summary>
    /// 
    /// </summary>
    public void Conditions()
    {
        //conditions CurrentConditions = new conditions();
        
        picbox_conditions_icon.Image = weatherIcon((string)CurrentConditions.icon, "Day");
        tabPageConditions.BackgroundImage = CurrentConditions.bg_image;
        System.Diagnostics.Debug.Print((string)CurrentConditions.icon);
        DateTime dt = DateTime.Parse(CurrentConditions.local_time_rfc822.ToString().Substring(0, 17));
        lbl_Condition_Day.Text = String.Format("{0:dddd, MMM d, yyyy}", dt);
        //Condition_grpBx_Temp.Text = String.Format("{0:dddd}", dt);
        //lbl_Condition_Day.Text = String.Format("{0:ddd, MMM d, yyyy}", CurrentConditions.local_time_rfc822.ToString().Substring(0, 17));
        lbl_Condition_temp.Text = String.Format("Temp:\n {0:00° F}", CurrentConditions.temp_f);
        lbl_Condition_feels.Text = String.Format("Feels Like: {0}", CurrentConditions.feelslike_string);
        lbl_Condition_humidity.Text = String.Format("Humidity: {0}", CurrentConditions.relative_humidity);
        lbl_Condition_visibleMi.Text = String.Format("Visibility: {0} (Miles)", CurrentConditions.visibility_mi);
        lbl_Condition_Weather.Text = String.Format("{0}", CurrentConditions.weather);
        lbl_Condition_wind.Text = String.Format("{0}", CurrentConditions.wind_string);
        lbl_Condition_dewpoint.Text = String.Format("Dewpoint: {0}", CurrentConditions.dewpoint_string);
        lbl_Condition_UV.Text = String.Format("UV Index: {0}", CurrentConditions.UV);
        lbl_Condition_pressure_mb.Text = String.Format("Prssure Mb: {0}", CurrentConditions.pressure_mb);
        lbl_Condition_pressure_in.Text = String.Format("Pressure: {0} (inches", CurrentConditions.pressure_in);
        lbl_Condition_pressure_trend.Text = String.Format("Pressure Trend: {0}", CurrentConditions.pressure_trend);
        lbl_Condition_precip_today_in.Text = String.Format("Precip today: {0} (inches)", CurrentConditions.precip_today_in);
        lbl_Condition_precip_1hr.Text = String.Format("Precip 1 Hour: {0} (inches)", CurrentConditions.precip_1hr_in);
        lbl_condition_city.Text = String.Format("City: {0}", CurrentConditions.display_location_full);
        lbl_Condition_zip.Text = String.Format("Zip Code: {0}", CurrentConditions.display_location_zip);
        lbl_condition_station.Text = String.Format("Station ID: {0}", CurrentConditions.station_id);
        lbl_Condition_latitude.Text = String.Format("Latitude: {0}", CurrentConditions.display_location_latitude);
        lbl_Condition_long.Text = String.Format("Longtitude: {0}", CurrentConditions.display_location_longitude); ;
        lbl_Condition_elevation.Text = String.Format("Elevation: {0}", CurrentConditions.display_location_elevation);


        //Set 3 Day forecast on Conditions tab
        Condition_grpBx_D1summary.Text = String.Format("{0}", simple2.title);
       // lbl_condition_day2.Text = String.Format("{0}", simple2.title);
        lbl_Condition_temp2.Text  = String.Format("HI: {0}  /  LOW: {1}", Day2.fahrenheitHi ,Day2.fahrenheitLow);
        lbl_Condition_fctext2.Text  = String.Format("{0}", simple2.fcstText);
        picbox_conditions_icon2.Image = weatherIcon((string)simple2.icon, "Day");

        Condition_grpBx_D2summary.Text = String.Format("{0}", simple3.title);
        //lbl_condition_day3.Text = String.Format("{0}", simple3.title);
        lbl_Condition_temp3.Text = String.Format("HI: {0}  /  LOW: {1}", Day3.fahrenheitHi, Day3.fahrenheitLow);
        lbl_Condition_fctext3.Text = String.Format("{0}", simple3.fcstText);
        picbox_conditions_icon3.Image = weatherIcon((string)simple2.icon, "Day");

        Condition_grpBx_D3summary.Text = String.Format("{0}", simple4.title);
       // lbl_condition_day4.Text = String.Format("{0}", simple4.title);
        lbl_Condition_temp4.Text = String.Format("HI: {0}  /  LOW: {1}", Day4.fahrenheitHi, Day4.fahrenheitLow);
        lbl_Condition_fctext4.Text = String.Format("{0}", simple4.fcstText);
        picbox_conditions_icon4.Image = weatherIcon((string)simple4.icon, "Day");
        //txtbox_debug_debug.Text = String.Format("{0}", Day2.weekday);
        
        //WEBmapbrowser.Url = new Uri(comboBox1.Text);
        //webBrowser1.Url = new Uri(comboBox1.Text);
            
         	WebRequest req = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.gif?centerlat=30&centerlon=-85.4&radius=100&width=650&height=420&newmaps=1");
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();
            // byte[] imageData = DownloadData("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&maxlon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0"); //DownloadData function from here
            //MemoryStream stream = new MemoryStream(imageData);
            Image imgsat = Image.FromStream(stream);
            stream.Close();
            Map.pictureMap.Image = imgsat;
            //picRadar.Image = imgsat;
    }


    void MainMap_OnPositionChanged(PointLatLng point)
    {
        string lat = point.Lat.ToString(CultureInfo.InvariantCulture);
        string lng = point.Lng.ToString(CultureInfo.InvariantCulture);
        textboxLat.Text = lat;
        textboxLon.Text = lng;

        statusbarLongLat.Text = String.Format("Longitude:[{0}] ::: Latitude:[{1}]", lng, lat);
       // statusbarMapZoom.Text = String.Format("Map Zoom Level = {0}", gMap.Zoom);
    }

    void readJson(string city)
    {
        var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/forecast10day/q/" + city + ".json");
        request.ContentType = "application/json";
        var response = (HttpWebResponse)request.GetResponse();

        using (var sr = new StreamReader(response.GetResponseStream()))
        {
            Globals.forecast10 = sr.ReadToEnd();
        }
        //JObject o = JObject.Parse(textjson);
        //Debug.Print("forecast: " +o["forecast"]["txt_forecast"]["forecastday"][0]);


    }

    //void readJson(string city, string category = "forecast10day")
    //{

    //    var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/"+ category +"/q/" + city + ".json");
    //    request.ContentType = "application/json";
    //    var response = (HttpWebResponse)request.GetResponse();

    //    using (var sr = new StreamReader(response.GetResponseStream()))
    //    {
    //        switch (category)
    //        {
    //            case "forecast10day":
    //                Globals.forecast10 = sr.ReadToEnd();
    //                break;
    //            case "conditions":
    //                Globals.conditions = sr.ReadToEnd();
    //                break;

    //        }



    //    }
    //    //JObject o = JObject.Parse(textjson);
    //    //Debug.Print("forecast: " +o["forecast"]["txt_forecast"]["forecastday"][0]);


    //}


    /// <summary>
    /// 
    /// </summary>
    /*void GMapLoad()
    {
        gMap.SetPositionByKeywords("Tallahassee, FL");
        statusbarMapZoom.Text = String.Format("Map Zoom Level = {0}", gMap.Zoom);
        GMapProvider provider = GMapProviders.BingHybridMap;
        gMap.MapProvider = provider;
        gMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);


        //WebRequest req = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&maxlon=-67.00&minlat=23.00&minlon=-140.00&width=1423&height=519&newmaps=0");

        WebRequest req = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?centerlat=30.4392020872356&centerlon=-84.287109375&radius=900&width=1423&height=750&newmaps=0");
        WebResponse response = req.GetResponse();
        Stream stream = response.GetResponseStream();
        // byte[] imageData = DownloadData("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&maxlon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0"); //DownloadData function from here
        //MemoryStream stream = new MemoryStream(imageData);
        //Image imgsat = Image.FromStream(stream);
       // stream.Close();


        //mainOverlay = new GMapOverlay("top");
        ////gMap.Overlays.Add(mainOverlay);

        //GMapImage clouds = new GMapImage(gtl);
        //clouds.Image = imgsat;
       // mainOverlay.Markers.Add(clouds);

        // clouds.Image = Properties.Resources.USOverlay;



        }

    */
    public void zipcode(string zipstring)
    {

        var request = WebRequest.Create("http://autocomplete.wunderground.com/aq?query=" + zipstring);
        request.ContentType = "application/json";
        var response = (HttpWebResponse)request.GetResponse();

        using (var sr = new StreamReader(response.GetResponseStream()))
        {
            Globals.zipCity = sr.ReadToEnd();
        }
        JObject o = JObject.Parse(Globals.zipCity);
        JArray items = (JArray)o["RESULTS"];
        int length = items.Count;

        for (int i = 0; i < items.Count; i++)
        {
            //var item = (JObject)items[i];
            string zipName = (string)o["RESULTS"][i]["name"];
            string zipZip = (string)o["RESULTS"][i]["zmw"];
            zipZip = zipZip.Substring(0, 5);
            zipName = string.Format("{0} - {1}", zipName, zipZip);
            zipBox.Items.Add(zipName);

        }

        zipBox.DroppedDown = true;
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {


       // textboxMapHght.Text = String.Format("{0}", gMap.Height);
       // textboxMapWidth.Text = String.Format("{0}", gMap.Width);



    }

   

    private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
       
    }

    private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Return)

        {
            //gMap.Overlays.Clear();
            WebRequest req = WebRequest.Create(comboBox2.Text);
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();
            // byte[] imageData = DownloadData("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&maxlon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0"); //DownloadData function from here
            //MemoryStream stream = new MemoryStream(imageData);
            Image imgsat = Image.FromStream(stream);
            stream.Close();


            //mainOverlay = new GMapOverlay("top");
            //gMap.Overlays.Add(mainOverlay);

    //        GMapImage clouds = new GMapImage(gtl);
    //        clouds.Image = imgsat;
    //        mainOverlay.Markers.Add(clouds);
    //    }
    //}

    //private void gMap_OnMapZoomChanged()
    //{
    //    if (clouds != null)
    //    {
    //        var tl = gMap.FromLatLngToLocal(gtl);
    //        var br = gMap.FromLatLngToLocal(gbr);

    //        clouds.Position = gtl;
    //        clouds.Size = new System.Drawing.Size((int)(br.X - tl.X), (int)(br.Y - tl.Y));
        }


    }

    private void MainForm_Load(object sender, EventArgs e)
    {
       Condition_grpBx_D1summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        Condition_grpBx_D2summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        Condition_grpBx_D3summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        //panelDay4.Width = (flowLayoutPanelForecast4.Width / 4) - 10;
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        Condition_grpBx_D2summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        Condition_grpBx_D3summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        Condition_grpBx_D1summary.Width = (Condition_FlowPanel_3day.Width / 3) - 10;
        //panelDay4.Width = (flowLayoutPanelForecast4.Width / 4) - 10;
    }

    private void tabPage4_Click(object sender, EventArgs e)
    {
       
    }

    

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void lblD1_Click(object sender, EventArgs e)
    {

    }

    private void n1Hi_Click(object sender, EventArgs e)
    {

    }

    private void picboxD1_Click(object sender, EventArgs e)
    {

    }

    private void lblN1_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Condition_feels_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Condition_zip_Click(object sender, EventArgs e)
    {

    }

    private void lbl_condition_city_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Condition_latitude_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Condition_long_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Condition_elevation_Click(object sender, EventArgs e)
    {

    }

    private void chartControl1_Click(object sender, EventArgs e)
    {

    }

    private void radialGauge1_Paint(object sender, PaintEventArgs e)
    {
        //radialGauge1.Value = Convert.ToInt16(CurrentConditions.temp_f.ToString());
    }

    private void lbl_Condition_UV_Click(object sender, EventArgs e)
    {

    }
	void ComboBox1KeyPress(object sender, KeyPressEventArgs e)
	{
		 if (e.KeyChar == (char)Keys.Return)
        {
            WEBmapbrowser.Url = new Uri(comboBox1.Text);
            //webBrowser1.Url = new Uri(comboBox1.Text);
            
            WebRequest req = WebRequest.Create(comboBox1.Text);
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();
            // byte[] imageData = DownloadData("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&maxlon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0"); //DownloadData function from here
            //MemoryStream stream = new MemoryStream(imageData);
            Image imgsat = Image.FromStream(stream);
            stream.Close();
            
            //picRadar.Image = imgsat;
            
            
            
        }
	}
	void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
	{

	}




    //string ReadAPI(string file)
    //{
    //    file = string.Format(@"C:\API\{0}", file);
    //    string value2 = File.ReadAllText(file);
    //    return value2;
    //}
}

//public class forecast4
//    {
//        JObject o = JObject.Parse(Globals.forecast10);
//    //txt_forecast
//    public JToken period {get; set; }


//    public JToken icon { get; set; }
//    public JToken iconurl { get; set; }
//    public JToken title { get; set; }
//    public JToken fcstText { get; set; }
//    public JToken precipChance { get; set; }

//    public JToken day { get; set; }
//    public JToken month { get; set; }
//    public JToken year { get; set; }
//    public JToken monthname { get; set; }
//    public JToken weekday_short { get; set; }
//    public JToken weekday { get; set; }
//    public JToken ampm { get; set; }
//    public JToken tz_short { get; set; }
//    public JToken tz_long { get; set; }

//    public JToken fahrenheitHi { get; set; }
//    public JToken fahrenheitLow { get; set; }
//    public JToken celsiusHi { get; set; }
//    public JToken celsiusLow { get; set; }

//    public JToken conditions { get; set; }
//    public JToken iconURL { get; set; }
//    public JToken skyIcon { get; set; }
//    public JToken rainInch { get; set; }
//    public JToken rainMM { get; set; }
//    public JToken snowInch { get; set; }
//    public JToken snowMM { get; set; }
//    public JToken maxWindmph { get; set; }
//    public JToken maxWindkph { get; set; }
//    public JToken maxWinddir { get; set; }
//    public JToken maxWinddegrees { get; set; }
//    public JToken avgWindmph { get; set; }
//    public JToken avgWindkph { get; set; }
//    public JToken avgWinddir { get; set; }
//    public JToken avgWinddegrees { get; set; }
//    public JToken avgHumidity { get; set; }
//    public JToken maxHumidity { get; set; }
//    public JToken minHumidity { get; set; }

//    public forecast4(int num) {
//            //text forecast
//            this.period = (o["forecast"]["txt_forecast"]["forecastday"][num]["period"]);
//            this.iconurl = (o["forecast"]["txt_forecast"]["forecastday"][num]["iconurl"]);
//            this.title = (o["forecast"]["txt_forecast"]["forecastday"][num]["title"]);
//            this.fcstText = (o["forecast"]["txt_forecast"]["forecastday"][num]["fcttext"]);
//            this.precipChance = (o["forecast"]["txt_forecast"]["forecastday"][num]["pop"]);


//            //simeple forecast (extended) 

//            //Date
//            this.day = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["day"]);
//            this.month = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["month"]);
//            this.year = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["year"]);
//            this.monthname = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["monthname"]);
//            this.weekday_short = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["weekday_short"]);
//            this.weekday = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["weekday"]);
//            this.ampm = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["ampm"]);
//            this.tz_short = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["tz_short"]);
//            this.tz_long = (o["forecast"]["simpleforecast"]["forecastday"][num]["date"]["tz_long"]);


//            //Weather
//            this.fahrenheitHi = (o["forecast"]["simpleforecast"]["forecastday"][num]["high"]["fahrenheit"]);
//            this.fahrenheitLow = (o["forecast"]["simpleforecast"]["forecastday"][num]["low"]["fahrenheit"]);
//            this.celsiusHi = (o["forecast"]["simpleforecast"]["forecastday"][num]["high"]["celsius"]);
//            this.celsiusLow = (o["forecast"]["simpleforecast"]["forecastday"][num]["low"]["celsius"]);

//            this.conditions = (o["forecast"]["simpleforecast"]["forecastday"][num]["conditions"]);
//            this.icon = (o["forecast"]["simpleforecast"]["forecastday"][num]["icon"]);
//            this.iconURL = (o["forecast"]["simpleforecast"]["forecastday"][num]["iconURL"]);
//            this.skyIcon = (o["forecast"]["simpleforecast"]["forecastday"][num]["skyicon"]);
//            this.maxWindmph = (o["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["mph"]);
//            this.maxWindkph = (o["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["kph"]);
//            this.maxWinddir = (o["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["dir"]);
//            this.maxWinddegrees = (o["forecast"]["simpleforecast"]["forecastday"][num]["maxwind"]["degrees"]);
//            this.maxHumidity = (o["forecast"]["simpleforecast"]["forecastday"][num]["maxhumidity"]);

//            this.avgWindmph = (o["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["mph"]);
//            this.avgWindkph = (o["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["kph"]);
//            this.avgWinddir = (o["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["dir"]);
//            this.avgWinddegrees = (o["forecast"]["simpleforecast"]["forecastday"][num]["avewind"]["degrees"]);
//            this.avgHumidity = (o["forecast"]["simpleforecast"]["forecastday"][num]["avehumidity"]);

//            this.minHumidity = (o["forecast"]["simpleforecast"]["forecastday"][num]["minhumidity"]);

//        }

//        public string readJson(int num, string input)
//        {
//            return Convert.ToString(o["forecast"]["txt_forecast"]["forecastday"][num][input]);
//        }


//    }



//public class GMapImage : GMapMarker
//{
//    private Image image;
//    public Image Image
//    {
//        get
//        {
//            return image;
//        }
//        set
//        {
//            image = value;
//            if (image != null)
//            {
//                this.Size = new Size(image.Width, image.Height);
//            }
//        }
//    }

//    public GMapImage(GMap.NET.PointLatLng p)
//       : base(p)
//    {
//        DisableRegionCheck = true;
//        IsHitTestVisible = false;
//    }

//    public override void OnRender(Graphics g)
//    {
//        if (image == null)
//            return;

//        g.DrawImage(image, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
//    }
//}




