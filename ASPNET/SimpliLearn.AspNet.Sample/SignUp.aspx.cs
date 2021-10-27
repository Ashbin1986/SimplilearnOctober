using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpliLearn.AspNet.Sample
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["OnlineUsers"] !=null)
            {
                Application["OnlineUsers"] = Convert.ToInt32(Application["OnlineUsers"]) + 1;

                Response.Write("Online Users count : " + Application["OnlineUsers"]);
            }
        }
    }
}