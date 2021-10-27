using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpliLearn.AspNet.Sample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies["LoginInformation"];
            if(httpCookie !=null)
            {
                txtUserName.Text = httpCookie["UserName"].ToString();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text=="123")
            {
                HttpCookie httpCookie = new HttpCookie("LoginInformation");
                httpCookie["UserName"] = txtUserName.Text;
                httpCookie.Expires.AddDays(1);
                Response.Cookies.Add(httpCookie);
                Session["User"] = txtUserName.Text;
                spError.InnerText = "Login Success";
                //Response.Redirect("About.aspx?status=loginsuccess");
                Response.Redirect("About.aspx?recordid=1");
            }
            else
            {
                spError.InnerText = "Login failed";
            }
        }
    }
}