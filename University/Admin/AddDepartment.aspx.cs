using System;
using System.Web.UI;
using Database;

namespace University.Admin
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            DEPARTMENT_TABLE de = new DEPARTMENT_TABLE();
            string de_id = this.TextID.Value;
            string de_name = this.TextName.Value;
            string de_description = this.TextDescription.Value;

            if (de.insertDepartment(de_id, de_name, de_description))
            {
                ImageButtonCreate.Attributes.Add("OnClick","alert('Add new department successful')");
                Response.Redirect("ViewDepartment.aspx");
            }
        }
    }
}