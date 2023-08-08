using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace XML_Web_Service_OddEven
{
    /// <summary>
    /// Summary description for WebService_OddEven
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_OddEven : System.Web.Services.WebService
    {

        [WebMethod]
        public string testOddEven(int num)
        {
            if (num % 2 == 0)
            {
                return num + "Is Even Number";
            }
            else
            {
                return num + "Is Odd Number";
            }
        }
    }
}
