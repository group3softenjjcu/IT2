using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace University
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            Response.Redirect("Home.aspx");
            MesgBox("aaaaa");
        }

        private void MesgBox(string sMessage)
        {
            string msg = "";
            msg = "<script language='javascript'>";
            msg += "alert('" + sMessage + "')";
            msg += "<" + "/script>";
            Response.Write(msg);
        }
    }
}