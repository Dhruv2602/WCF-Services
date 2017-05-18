using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GasPrices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string gasPrices(string latitude, string longitude)
        {
            string url1 = "http://devapi.mygasfeed.com/stations/radius/" + latitude + "/" + longitude + "/50/reg/price/rfej9napna.json?callback=?";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            string result = responseFromServer.Split('\n').Reverse().Take(1).ToArray()[0];
            int ind = result.IndexOf("{\"status\"");
            result = result.Substring(ind);
            result = result.Substring(0,result.Length - 1);
            JObject j = JObject.Parse(result);
            JArray stations = (JArray)j.GetValue("stations");

            if (stations.Count == 0)
                return "No Gas Stations Nearby";

            string resp = "";
            double m = Double.MaxValue;
            foreach (var item in stations)
            {
                JToken price = item["reg_price"];
                double priceD = 0;
                if (Double.TryParse(price.ToString(), out priceD))
                {
                    m = Math.Min(m, priceD);
                }
            }
            resp = m.ToString();
            return resp;
        }
    }
}
