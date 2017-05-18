using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NewsFocus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] NewsFocus(string[] topics)
        {
            List<string> urlcol= new List<string>();
            foreach (string topic in topics)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://news.google.com/news?q=" + topic + "&output=rss");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream resp = response.GetResponseStream();
                    StreamReader read = new StreamReader(resp);
                    if (response.CharacterSet != "")
                    {
                        read = new StreamReader(resp, Encoding.GetEncoding(response.CharacterSet));
                    }
                    string data = read.ReadToEnd();

                    DataSet ds = new DataSet();
                    StringReader sr = new StringReader(data);
                    ds.ReadXml(sr);
                    DataTable table = new DataTable();

                    if (ds.Tables.Count > 0)
                    {
                        table = ds.Tables["item"];
                        
                        foreach (DataRow row in table.Rows)
                        {
                            string url = row["link"].ToString();
                            int ind = url.IndexOf("url=");
                            url = url.Substring(ind+4);
                            urlcol.Add(url);
                        }
                    }
                }
            }
            return urlcol.ToArray();
        }
    }
}
