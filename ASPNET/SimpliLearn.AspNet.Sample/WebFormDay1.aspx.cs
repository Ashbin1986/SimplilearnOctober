using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpliLearn.AspNet.Sample
{
    public partial class WebFormDay1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(fileuploadImage.HasFile)
            {
                fileuploadImage.SaveAs(Server.MapPath("~/Files/" + fileuploadImage.FileName));
                lblError.Text = "File uploaded successfully !.";
                img.ImageUrl = "~/Files/" + fileuploadImage.FileName;
            }
            else
            {
                lblError.Text = "File not selected !.";
            }
        }
    }

}