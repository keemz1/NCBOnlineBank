using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices.Web_Services
{
    /// <summary>
    /// Summary description for JPSWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class JPSWebService : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public bool ValidateAccount(int customerNumber /*, int premiseNumber, string category*/)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OnlineBankConnection"].ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"SELECT * from PayeeAccounts where CustomerNumber = {customerNumber})";
                    //and PremisesNumber = { premiseNumber } and tolower(Category) = tolower({ category}
                    var result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
