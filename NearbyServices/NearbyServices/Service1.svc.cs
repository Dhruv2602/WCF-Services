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

namespace NearbyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string nearbyGasStations(string latitude, string longitude)
        {
            string url1 = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + latitude + "," + longitude + "&radius=5000&type=gas_station&key=AIzaSyCGYZabm7mUbtcC6vUv5vSxr92ULKcinkk";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            JObject j = JObject.Parse(responseFromServer);
            JArray results = (JArray)j.GetValue("results");

            if (results.Count == 0)
                return "No Gas Stations Found";

            string resp = "";
            foreach (var item in results)
            {
                JToken name = item["name"];
                resp += name.ToString() + ", ";
            }
            return resp;
        }

        public string nearbyPostOffices(string latitude, string longitude)
        {
            string url1 = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + latitude + "," + longitude + "&radius=5000&type=post_office&key=AIzaSyCGYZabm7mUbtcC6vUv5vSxr92ULKcinkk";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            JObject j = JObject.Parse(responseFromServer);
            JArray results = (JArray)j.GetValue("results");

            if (results.Count == 0)
                return "No Post Offices Found";

            string resp = "";
            foreach (var item in results)
            {
                JToken name = item["name"];
                resp += name.ToString() + ", ";
            }
            return resp;
        }

        public string nearbyShoppingMalls(string latitude, string longitude)
        {
            string url1 = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + latitude + "," + longitude + "&radius=5000&type=shopping_mall&key=AIzaSyCGYZabm7mUbtcC6vUv5vSxr92ULKcinkk";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            JObject j = JObject.Parse(responseFromServer);
            JArray results = (JArray)j.GetValue("results");

            if (results.Count == 0)
                return "No Shopping Malls Found";

            string resp = "";
            foreach (var item in results)
            {
                JToken name = item["name"];
                resp += name.ToString() + ", ";
            }
            return resp;
        }
    }
}
