using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SimpleWS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Name = "Web Service", Namespace = "https://localhost:44364/", Description = "This is The First Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string str)
        {
            return "Hello, " + str;
        }

        [WebMethod]
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        [WebMethod]
        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        [WebMethod]
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        [WebMethod]
        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
