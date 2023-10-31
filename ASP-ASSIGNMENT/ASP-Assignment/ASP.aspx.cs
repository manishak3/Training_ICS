using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_ASSIGNMENT
{
    public partial class ASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the default image when the page loads
                imgItem.ImageUrl = "Images/default.jpg";
            }
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            
            string SelectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (SelectedItem == "1")
            {

                cost = "65000";

            }

            else if (SelectedItem == "2")
            {

                cost = "80000";
            }

            else if (SelectedItem == "3")
            {

                cost = "150000";
            }
           
            string Item = ddlItems.SelectedItem.Text;

            lblCost.Text = $"Cost of {Item}: {cost}";

        }

        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When an item is selected, update the image accordingly
            string selectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "1")
            {
                imgItem.ImageUrl = $"Images/DELL.jpg";
            }

            else if (selectedItem == "2")
            {
                imgItem.ImageUrl = $"Images/HP.jpg";

            }

            else if (selectedItem == "3")
            {
                imgItem.ImageUrl = $"Images/MAC.jpg";

            }
             else
            {

                imgItem.ImageUrl = $"Images/{"Images/default.jpg"}";
            }
        }
    }


}