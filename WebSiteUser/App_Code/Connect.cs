using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteUser
{
    public class Connect
    {
        const string FILE_NAME = "UserForm.mdb";
        public static string getConnectionString()
        {
            string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; data source=" + location;

            return ConnectionString;
        }
    }
}