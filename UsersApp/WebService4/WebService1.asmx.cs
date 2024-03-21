using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace WebService4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string dataTableForUsers(string id )
        {
            string query = "Select * From Users Where ID = '" + id + "' ";
            objDBAccess.readDatathroughAdapter(query, dtUsers);

            string result = JsonConvert.SerializeObject(dtUsers);
            return result;
        }
    }
}
