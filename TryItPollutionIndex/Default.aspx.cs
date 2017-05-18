using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string city = TextBox1.Text;

        string url1 = "http://localhost:55108/Service1.svc/pollution?string=" + city;
        string url = @url1;

        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream data = response.GetResponseStream();
        StreamReader reader = new StreamReader(data);
        string responseFromServer = reader.ReadToEnd();
        response.Close();

        Label1.Text = responseFromServer;

    }
}