using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebSiteUser
{
    public partial class UserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack )
                LoadCities(); 
        }
        protected void LoadCities()
        {
            UserService service = new UserService();
            List<string> obj = service.getCities();
            foreach (string city in obj)
            {
                cities.Items.Add(city);
            }
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && check_id(id.Text))
            {
                UserService service = new UserService();
                UserDetails user = new UserDetails();
                user.FirstName = this.TextBoxFirstname.Text;
                user.LastName = lastname.Text;
                user.ID = id.Text;
                user.Phone = phone.Text;
                user.BirthDate = birthdate.Value;
                user.City = cities.SelectedValue;
                user.Address = address.Text;
                user.State = state.Text;
                user.Zip = zip.Text;
                user.Username = username.Text;
                user.Password = password.Value;
                try
                {
                    service.AddUser(user);
                    Label1.Text = "user added";
                }
                catch (Exception ex)
                {
                    this.Label1.Text = ex.Message;
                }
            }

        }
        public bool check_id(string id)
        {
            char[] digits = id.PadLeft(9, '0').ToCharArray();
            int[] oneTwo = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int[] multiply = new int[9];
            int[] oneDigit = new int[9];
            for (int i = 0; i < 9; i++)
                multiply[i] = Convert.ToInt32(digits[i].ToString()) * oneTwo[i];
            for (int i = 0; i < 9; i++)
                oneDigit[i] = (int)(multiply[i] / 10) + multiply[i] % 10;
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += oneDigit[i];
            if (sum % 10 == 0)
                return true;
            else
            {
                Label1.Text = "Invalid ID";
                return false;
            }
                
        }
    }
}