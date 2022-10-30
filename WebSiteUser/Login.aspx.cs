using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteUser
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            List<string> obj = service.login(username.Text, password.Text);
            foreach (string i in obj)
            {
                
            }
        }

        //protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        //{
        //    UserService service = new UserService();
        //    List<string> obj = service.login(Login1.UserName, Login1.Password);
        //    foreach (string city in obj)
        //    {
        //        DropDownList1.Items.Add(city);
        //    }
        //}
    }
}