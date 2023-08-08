using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_Service_Odd_Even_Client
{
    public partial class OddEvenWebserviceClient : System.Web.UI.Page
    {
        ServiceReference1.WebService_OddEvenSoapClient proxy1 = new ServiceReference1.WebService_OddEvenSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum.Text);

            lbloutput.Text = proxy1.testOddEven(n);

        }
    }
}