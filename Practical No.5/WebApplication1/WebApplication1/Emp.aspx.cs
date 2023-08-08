using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Emp : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDet.GetData();

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}