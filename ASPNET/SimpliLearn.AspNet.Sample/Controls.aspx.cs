using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpliLearn.AspNet.Sample
{
   
    public partial class Controls : System.Web.UI.Page
    {
        public string str = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lnkSubmit_Click(object sender, EventArgs e)
        {
            str = "Hello";
            ViewState["myValue"] = "10001";
            hdnEmpId.Value = str;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Write("Value is : " + ViewState["myValue"]);
            Response.Write("Value is : " + hdnEmpId.Value);
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}