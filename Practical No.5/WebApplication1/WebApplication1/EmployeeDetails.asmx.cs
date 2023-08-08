using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for EmployeeDet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeDet : System.Web.Services.WebService
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(conStr);
        SqlCommand cmd = null;

        SqlDataReader dr = null;
        DataTable dt = null;
        [WebMethod]
        public string InsertRecord(int EmpId, string EmpName, string EmpAdd)
        {

            string msg;
            try
            {
                cmd = new SqlCommand("INSERT INTO Employee(EmpId, EmpName, EmpAdd) VALUES(@id,@nm,@add)", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@id", EmpId);
                cmd.Parameters.AddWithValue("@nm", EmpName);
                cmd.Parameters.AddWithValue("@add", EmpAdd);

                int r = cmd.ExecuteNonQuery();

                if (r != 0)
                {
                    msg = "Record inserted Successfully";
                }
                else
                {
                    msg = "Record not found";
                }
            }
            catch (Exception ex)
            {
                msg = "Exception ! " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }

        [WebMethod]
        public DataTable displayAllRecord()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Employee", conn);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                    dt = new DataTable("Employee");
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
    }

    
}
