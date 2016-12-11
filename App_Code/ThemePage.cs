using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ThemePage
/// </summary>
public partial class ThemePage : System.Web.UI.Page
{
    protected string themeSelect = null;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Request.Cookies["Theme"] != null)
        {
            themeSelect = Request.Cookies["Theme"].Value.ToString();
            switch (themeSelect)
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

        /* if ((string)(Session["Theme"]) != null)
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
         } */

    }
    public ThemePage()
    {
        //
        // TODO: Add constructor logic here
        //
    }



    public void SetCookie(string name, string value, int expireDays =10)
    {
        HttpCookie cookie = new HttpCookie(name, value);
        cookie.Expires = DateTime.Now.AddDays(expireDays);
        Response.SetCookie(cookie);
    }


    public string GetCookie(string name, string defaultValue = null)
    {
        if (Request.Cookies[name] != null)
        {
            return Request.Cookies[name].Value.ToString();
        }
        else
        {
            return defaultValue;
        }
    }  
}