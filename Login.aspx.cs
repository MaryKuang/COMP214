
/* Yu Kuang 300540907 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

// System.Web.UI.Page
public partial class Login :ThemePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            //if ((userName.Text == "admin" && password.Text == "admin") || (userName.Text == "mary" && password.Text == "mary"))
            //{
            //    //  FormsAuthentication.RedirectFromLoginPage(userName.Text, false);
            //    Response.Redirect("Home.aspx");
            //}
        }

    }



    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }

    //protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    //{
      
    //}


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if ((userName.Text == "admin" && password.Text == "admin") || (userName.Text == "mary" && password.Text == "mary"))
        {
            FormsAuthentication.RedirectFromLoginPage(userName.Text, false);
          //  Response.Redirect("Home.aspx");
        }
        else
        {
            Response.Write("<script>alert('Password is not correct!')</script>");
           // Response.Redirect("Login.aspx");
        }

    }

    protected void btnManage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Usermanagement.aspx");
    }
}