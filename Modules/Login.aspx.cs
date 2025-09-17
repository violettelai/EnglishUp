using EnglishUp.Util;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishUp
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.Authenticate += LoginUser;
        }

        protected void LoginUser(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string password = Login1.Password;

            bool isValid = AuthHelper.Login(username, password); // example helper
            e.Authenticated = isValid;

            if (isValid)
            {
                Response.Redirect("~/About.aspx");
            }
        }
    }
}