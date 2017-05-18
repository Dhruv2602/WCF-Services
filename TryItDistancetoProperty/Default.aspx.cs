using System;
using System.Collections.Generic;
using System.Linq;
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
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        string org = TextBox1.Text;
        string des = TextBox2.Text;
        Label1.Text = client.getDistance(org, des);
    }
}