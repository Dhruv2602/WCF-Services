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
        string latitude = TextBox1.Text;
        string longitude = TextBox2.Text;
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        Label1.Text = client.gasPrices(latitude, longitude);
    }
}