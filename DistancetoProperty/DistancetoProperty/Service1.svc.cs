using Newtonsoft.Json;
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

namespace DistancetoProperty
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getDistance(string origin, string dest)
        {
            string url1 = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + origin + "&destinations=" + dest + "&key=AIzaSyD4Mmn6PDRC3i0hdD6bh1aCNG4ToyEhas4";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            string dist = "";
            string resp = "";
            dynamic obj = JsonConvert.DeserializeObject(responseFromServer);

            try
            {
                foreach (var row in obj.rows)
                {
                    foreach (var element in row.elements)
                    {
                        dist = element.distance.text;
                    }
                }
            }
            catch
            {
                return "Error! Wrong origin or destination!";
            }
            
            resp = dist;
            return resp;
        }     
    }
}
