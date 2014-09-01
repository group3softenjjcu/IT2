﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;

namespace University
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        Encript encript = new Encript();
        STUDENTS_TABLE student = new STUDENTS_TABLE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                this.TextBoxUsername.Text = "";
                this.TextBoxPassword.Text = "";
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            
            string username = this.TextBoxUsername.Text;
            string password = this.TextBoxPassword.Text;

            password = encript.GetMD5Hash(password);
            if (username == "" || password == "") {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script type='text/javascript'>alert('Username and Password CAN'T be null!!!!');window.location='StudentLogin.aspx';</script>'");                
            }
            else{
            {
                if (student.checkAccount(username, password))
                {
                    Session["s_username"] = username;
                    Session["s_password"] = password;
                    Session["successful"] = 1;
                    Response.Redirect("Home.aspx");
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script type='text/javascript'>alert('Login unsuccessful, please try again!!!');window.location='StudentLogin.aspx';</script>'");                
            }
            
             
            
        }
        }
    }
}