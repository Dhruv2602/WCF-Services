using Newtonsoft.Json.Linq;
using SimpleOAuth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NearestStore
{
    class YelpAPIClient
    {
        private const string CONSUMER_KEY = "dvWTfryPmq02j7iJm51ptA";
        private const string CONSUMER_SECRET = "0b7HAUqdoeBks-Iuyv7yQQX335w";
        private const string TOKEN = "ZnVLvmy_oY23C2rU6lcXD35KKA7xOsGR";
        private const string TOKEN_SECRET = "bEw6hzJ8nQJwmzYyjuF-ee_CHX0";
        private const string API_HOST = "https://api.yelp.com";
        private const string SEARCH_PATH = "/v2/search/";
        private const int SEARCH_LIMIT = 1;

        private JObject PerformRequest(string baseURL, Dictionary<string, string> queryParams = null)
        {
            var query = System.Web.HttpUtility.ParseQueryString(String.Empty);

            if (queryParams == null)
            {
                queryParams = new Dictionary<string, string>();
            }

            foreach (var queryParam in queryParams)
            {
                query[queryParam.Key] = queryParam.Value;
            }

            var uriBuilder = new UriBuilder(baseURL);
            uriBuilder.Query = query.ToString();

            var request = WebRequest.Create(uriBuilder.ToString());
            request.Method = "GET";

            request.SignRequest(
                new Tokens
                {
                    ConsumerKey = CONSUMER_KEY,
                    ConsumerSecret = CONSUMER_SECRET,
                    AccessToken = TOKEN,
                    AccessTokenSecret = TOKEN_SECRET
                }
            ).WithEncryption(EncryptionMethod.HMACSHA1).InHeader();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            return JObject.Parse(stream.ReadToEnd());
        }

        public JObject Search(string term, string location)
        {
            string baseURL = API_HOST + SEARCH_PATH;
            var queryParams = new Dictionary<string, string>()
            {
                { "term", term },
                { "location", location },
                { "limit", SEARCH_LIMIT.ToString() }
            };
            return PerformRequest(baseURL, queryParams);
        }
    }
    

    public class Service1 : IService1
    {
        public string findNearestStore(string zipcode,string storeName)
        {
            var client = new YelpAPIClient();
            JObject response = client.Search(storeName, zipcode);
            JArray businesses = (JArray)response.GetValue("businesses");

            if(businesses.Count == 0)
            {
                return "No stores Found";
            }

            string res = response.ToString();
            int ind1 = res.IndexOf("display_address");
            int ind2 = res.IndexOf("geo_accuracy");
            return res.Substring(ind1+17, ind2 - ind1 - 17);
        }
    }
}
