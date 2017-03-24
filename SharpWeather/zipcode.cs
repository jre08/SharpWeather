using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharpWeather
{
    class zipcode
    {
        public zipcode(string zipstring)
        {

            string xUrl = "http://www.webservicex.net/uszip.asmx/GetInfoByCity?USCity=" + zipstring;
            XmlDocument doc = new XmlDocument();
            doc.Load(xUrl);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/NewDataSet/Table/ZIP");
                Debug.Print(node.InnerText);
            }
            


        }
    }

