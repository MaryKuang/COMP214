using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//System.Web.UI.Page
public partial class SetUp : ThemePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (rdnDark.Checked)
        {

            Session["Theme"] = "Dark";
            SetCookie("Theme", "Dark");
           
        }
        else if(rdnLight.Checked)
        {

            Session["Theme"] = "Light";
            SetCookie("Theme", "Light");

        }
        else
        {
            Session["Theme"] = "Default";
            SetCookie("Theme", "Default");
        }
        Response.Redirect("~/Home.aspx");


}
    

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        SetCookie("Theme", "Default");
        Session["Theme"] = "Default";
        Response.Redirect("~/Home.aspx");
    }
}