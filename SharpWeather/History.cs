﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace SharpWeather
{
    class History
    {
        JObject o = JObject.Parse(Globals.history);


    }
}