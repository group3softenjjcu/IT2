﻿using System;
using System.Web.UI;
using Database;

namespace University.Admin
{
    [Serializable()]
    public partial class AddEmployees : System.Web.UI.Page
    {
        EMPLOYEES_TABLE em = new EMPLOYEES_TABLE();
        DEPARTMENT_TABLE de = new DEPARTMENT_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                this.DropDownListDepartment.DataSource = de.listDEPARTMENT_TABLE();
                this.DropDownListDepartment.DataTextField = "de_name";
                this.DropDownListDepartment.DataValueField = "de_id";
                this.DropDownListDepartment.DataBind();                                            
            }            
        }           

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            string username = this.TextUsername.Value;
            string password = this.TextPassword.Value;
            string name = this.TextName.Value;            
            string phone = this.TextPhone.Value;
            bool gender = Convert.ToBoolean(this.RadioButtonListGender.SelectedItem.Value);                        
            string picture = FileUploadImage.FileName;

            FileUploadImage.SaveAs(Server.MapPath("upload/employee/" + picture));  

            string de_id = this.DropDownListDepartment.SelectedItem.Value;

            bool de_head = this.CheckBoxHead.Checked;
            bool active = this.CheckBoxActive.Checked;

            if (em.insertEMPLOYEES_TABLE(username, password, name, phone, gender, picture, de_id, de_head, active))
            {
                ImageButtonCreate.Attributes.Add("OnClick", "alert('Add new employee successful')");
                Response.Redirect("ViewEmployees.aspx");
            }
        }

             
    }
}