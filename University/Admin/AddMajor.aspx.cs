using System;
using System.Web.UI;
using Database;

namespace University
{
    public partial class AddMajor : System.Web.UI.Page
    {
        MAJOR_TABLE ma = new MAJOR_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            string ma_id = this.TextID.Value;
            string ma_name = this.TextName.Value;
            string ma_description = this.TextDescription.Value;

            if (ma.insertMAJOR_TABLE(ma_id, ma_name, ma_description))
            {
                ImageButtonCreate.Attributes.Add("OnClick", "alert('Add new major successful')");
                Response.Redirect("ViewMajor.aspx");
            }
            else {                
                return;
            }
        }
    }
}