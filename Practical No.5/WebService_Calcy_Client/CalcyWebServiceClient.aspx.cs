using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService_Calcy_Client
{
    public partial class CalcyWebServiceClient : System.Web.UI.Page
    {
        ServiceReference1.WebService_CalcySoapClient proxy1 = new ServiceReference1.WebService_CalcySoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum1.Text);
            int p = Convert.ToInt32(txtnum2.Text);

            lblresult.Text = proxy1.addition(n,p).ToString();
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum1.Text);
            int p = Convert.ToInt32(txtnum2.Text);

            lblresult.Text = proxy1.sub(n, p).ToString();

        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum1.Text);
            int p = Convert.ToInt32(txtnum2.Text);

            lblresult.Text = proxy1.mul(n, p).ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum1.Text);
            int p = Convert.ToInt32(txtnum2.Text);

            lblresult.Text = proxy1.div(n, p).ToString();
        }
    }
}