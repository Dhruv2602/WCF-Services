using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string topics = TextBox1.Text;
        if (topics == "")
            return;
        string[] topic = topics.Split(',');
        Label1.Text = "";

        ServiceReference1.Service1Client newsClient = new ServiceReference1.Service1Client();
        string[] news = newsClient.NewsFocus(topic);
        foreach (var item in news)
        {
            Label1.Text += item + ", ";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string zipcode = TextBox2.Text;
        string store = TextBox3.Text;

        if (zipcode == "" || store == "")
            return;

        ServiceReference2.Service1Client storeClient = new ServiceReference2.Service1Client();
        string address = storeClient.findNearestStore(zipcode, store);
        Label2.Text = address;
    }
}