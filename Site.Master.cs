using EnglishUp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishUp
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // IsPostBack = is page loaded for the first time or reload
            if (!IsPostBack)
            {
                navMenu.Visible = AuthHelper.IsLoggedIn();
            }
        }
    }
}