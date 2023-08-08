using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace XML_Web_Service_OddEven
{
    /// <summary>
    /// Summary description for WebService_Calcy
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Calcy : System.Web.Services.WebService
    {

        [WebMethod]
        public int addition(int n,int p)
        {
            return n + p;
            
        }
        [WebMethod]
        public int sub(int n, int p)
        {
            return n - p;

        }
        [WebMethod]
        public int mul(int n, int p)
        {
            return n * p;

        }
        [WebMethod]
        public int div(int n, int p)
        {
            return n / p;

        }
    }
}
