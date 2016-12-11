using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//System.Web.UI.Page

public partial class Home : ThemePage
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if ((string)(Session["Theme"]) != null)
        {
            switch ((string)(Session["Theme"]))
            {
                case "Dark":
                    Page.Theme = "Dark";
                    break;
                case "Light":
                    Page.Theme = "Light";
                    break;
                default:
                    Page.Theme = "Default";
                    break;
            }
        } 

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnList_Click(object sender, EventArgs e)
    {
        
       Response.Redirect("~/Addrecipe.aspx");
    }

    protected void btnStart_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SetUp.aspx");
    }

    /* public override String StyleSheetTheme
     {
         get { return "Light"; }
     }  */



    protected void btnSignUP_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Search.aspx");
    }
}