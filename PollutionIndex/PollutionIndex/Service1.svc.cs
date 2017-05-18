using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PollutionIndex
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getPollution(string city)
        {
            string url1 = "http://api.waqi.info/feed/" + city + "/?token=13043123132aca7f9f064ac16fb467e903548e8f";
            string url = @url1;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            response.Close();

            dynamic obj = JsonConvert.DeserializeObject(responseFromServer);
            string resp = "";

            try
            {
                resp = obj.data.aqi;
            }
            catch
            {
                return "Error! City not found in database!";
            }
            return resp;
        }
    }
}
