﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace University
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                /*
                if (Session["s_username"].ToString() != "")
                {
                    Session.Remove("s_username");
                    Response.Redirect("Home.aspx");
                }
                else {
                    Session.Remove("e_username");
                    Response.Redirect("Login.aspx");
                }
                 */
                Session.RemoveAll();
                Response.Redirect("Home.aspx");
            }
        }
    }
}