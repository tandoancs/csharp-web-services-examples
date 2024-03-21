using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

using System.ComponentModel;
using System.Web.Services.Protocols;


namespace ConvertCurrency
{
    /// <summary>
    /// Summary description for ConvertWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ConvertWS : System.Web.Services.WebService
    {
        //const
        private const double USD_RATE = 23450;
        private const double EUR_RATE = 25420;


        [WebMethod]
        public double VND2USD (double VND)
        {
            return VND / USD_RATE;
        }

        [WebMethod]
        public double VND2EUR(double VND)
        {
            return VND / EUR_RATE;
        }

        [WebMethod]
        public double USD2VND(double USD)
        {
            return USD * USD_RATE;
        }

        [WebMethod]
        public double EUR2VND(double EUR)
        {
            return EUR * EUR_RATE;
        }
    }
}

