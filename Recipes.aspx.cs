using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

//System.Web.UI.Page
public partial class Recipes : ThemePage
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
         if(!Page.IsPostBack)
        {
        List<Recipe> recipes = (List<Recipe>)Application["Recipe"];
            //  List<Ingredients> ingredients = (List<Ingredients>)Application["Ingredients"];

            string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID = COMP214F16_001_P_17; Password = password";
                string _sql;
           
            //   conn.ConnectionString = connectionString;

       //     OracleCommand comm = conn.CreateCommand();
         //   comm.CommandType = CommandType.Text;
           // comm.CommandText = "select * from recipes";
            //            comm.CommandText = "select recipeid,recipename,userid,categoryid,description from recipes";

            DataSet ds;
        try
        {
                // OracleConnection comm = new OracleConnection(_connstring);
                  conn.ConnectionString = connectionString;
                  OracleCommand comm = conn.CreateCommand();
                comm.Connection.Open();
                ds = new DataSet();
      //          comm.Open();
                _sql = "SELECT * FROM RECIPES_VIEW";
               
                OracleDataAdapter myDB = new OracleDataAdapter(_sql,conn);
          //  ds = new DataSet();
                myDB.Fill(ds);
               // comm.Close();
               // comm.Dispose();
              //  comm = null;
                conn.Close();
                conn.Dispose();
                conn = null;

                GridView1.DataSource = ds.Tables[0];
                // GridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
        {

             //   GridView1.DataSource = ds.Tables[0];

            }
            //    GridView1.DataSource = ds;
            //     GridView1.DataKeyNames = new string[]{ "recipeid" };
                GridView1.DataBind();  
          
        }
    }



  
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        //  int selectedRowIndex = GridView1.SelectedIndex;
        //  int recipeid = (int)GridView1.DataKeys[selectedRowIndex].Value;


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

       int selectedIndex = GridView1.SelectedIndex;
        GridViewRow row = GridView1.Rows[selectedIndex];
        string param = row.Cells[0].Text;
        Response.Redirect("DetailRecipe.aspx?param=" + param);  

    

    }
}