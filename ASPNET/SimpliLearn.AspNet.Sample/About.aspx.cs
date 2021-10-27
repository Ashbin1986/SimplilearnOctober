using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpliLearn.AspNet.Sample
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["recordid"] != null)
            {
                var recordid = Request.QueryString["recordid"];
                Response.Write(recordid);
                // DB call
            }
            if(Session["User"] !=null)
            {
                lblUserName.Text = Session["User"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx?status=your are not authorized.");
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();// clear the current session
            Response.Redirect("Login.aspx?status=logout");
        }
    }
}